namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetallesTransaccions", "ProductoNombre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetallesTransaccions", "ProductoNombre");
        }
    }
}
