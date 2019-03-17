namespace TalepWebUygulamasi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fileurl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taleps", "FileUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Taleps", "FileUrl");
        }
    }
}
