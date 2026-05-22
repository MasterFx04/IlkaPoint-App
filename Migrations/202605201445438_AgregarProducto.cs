namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarProducto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Inventarios", newName: "ServicioInventarios");
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        categoria = c.String(),
                        proveedor = c.String(),
                        precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        peso = c.Single(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.DetallesTransaccions", "ProductoId");
            AddForeignKey("dbo.DetallesTransaccions", "ProductoId", "dbo.Productoes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallesTransaccions", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.DetallesTransaccions", new[] { "ProductoId" });
            DropTable("dbo.Productoes");
            RenameTable(name: "dbo.ServicioInventarios", newName: "Inventarios");
        }
    }
}
