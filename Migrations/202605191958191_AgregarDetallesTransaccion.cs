namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarDetallesTransaccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetallesTransaccions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransaccionId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Transaccion_idTransaccion = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transaccions", t => t.Transaccion_idTransaccion)
                .Index(t => t.Transaccion_idTransaccion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallesTransaccions", "Transaccion_idTransaccion", "dbo.Transaccions");
            DropIndex("dbo.DetallesTransaccions", new[] { "Transaccion_idTransaccion" });
            DropTable("dbo.DetallesTransaccions");
        }
    }
}
