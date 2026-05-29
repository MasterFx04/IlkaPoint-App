namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transaccions", "Fecha", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transaccions", "MetodoPago", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transaccions", "MetodoPago");
            DropColumn("dbo.Transaccions", "Fecha");
        }
    }
}
