namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarStock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.ProductoId);
            
            AddColumn("dbo.Productoes", "rutaImagenPng", c => c.String());
            AddColumn("dbo.Transaccions", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Productoes", "peso", c => c.Decimal(precision: 18, scale: 2));
            DropTable("dbo.ServicioInventarios");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServicioInventarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Stocks", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.Stocks", new[] { "ProductoId" });
            AlterColumn("dbo.Productoes", "peso", c => c.Single());
            DropColumn("dbo.Transaccions", "Total");
            DropColumn("dbo.Productoes", "rutaImagenPng");
            DropTable("dbo.Stocks");
        }
    }
}
