namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDK5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productoes", "peso");
            DropColumn("dbo.Productoes", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Productoes", "peso", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
