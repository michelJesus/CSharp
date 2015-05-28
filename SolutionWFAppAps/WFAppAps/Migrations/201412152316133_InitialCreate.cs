namespace WFAppAps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        ContaId = c.Int(nullable: false, identity: true),
                        DataConta = c.DateTime(nullable: false),
                        TipoConta = c.String(),
                    })
                .PrimaryKey(t => t.ContaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contas");
        }
    }
}
