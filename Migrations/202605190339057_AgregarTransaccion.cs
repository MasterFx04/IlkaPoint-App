namespace IlkaPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTransaccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transaccions",
                c => new
                    {
                        idTransaccion = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.idTransaccion);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transaccions");
        }
    }
}
