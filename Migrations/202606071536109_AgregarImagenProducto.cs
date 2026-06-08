namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarImagenProducto : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productoes", "rutaImagenPng");
            AddColumn("dbo.Productoes", "rutaImagenPng", c => c.Binary());
        }

        public override void Down()
        {
            DropColumn("dbo.Productoes", "rutaImagenPng");
            AddColumn("dbo.Productoes", "rutaImagenPng", c => c.String());
        }
    }
}
