namespace TalepWebUygulamasi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class talep : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taleps",
                c => new
                    {
                        TalepId = c.Int(nullable: false, identity: true),
                        TalepKonusu = c.String(),
                        TalepAciklama = c.String(),
                    })
                .PrimaryKey(t => t.TalepId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Taleps");
        }
    }
}
