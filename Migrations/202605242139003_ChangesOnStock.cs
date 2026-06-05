namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesOnStock : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.Stocks", new[] { "ProductoId" });
            AddColumn("dbo.Stocks", "productoNombre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "productoNombre");
            CreateIndex("dbo.Stocks", "ProductoId");
            AddForeignKey("dbo.Stocks", "ProductoId", "dbo.Productoes", "id", cascadeDelete: true);
        }
    }
}
