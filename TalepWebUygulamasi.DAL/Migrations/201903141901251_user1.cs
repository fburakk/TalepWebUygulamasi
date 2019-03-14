namespace TalepWebUygulamasi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.HUsers");
            AlterColumn("dbo.HUsers", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.HUsers", "UserName");
            DropColumn("dbo.HUsers", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HUsers", "UserID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.HUsers");
            AlterColumn("dbo.HUsers", "UserName", c => c.String());
            AddPrimaryKey("dbo.HUsers", "UserID");
        }
    }
}
