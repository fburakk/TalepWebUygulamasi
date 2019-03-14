namespace TalepWebUygulamasi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HUsers", "Name", c => c.String());
            AddColumn("dbo.HUsers", "Surname", c => c.String());
            AddColumn("dbo.HUsers", "email", c => c.String());
            AddColumn("dbo.HUsers", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HUsers", "Role");
            DropColumn("dbo.HUsers", "email");
            DropColumn("dbo.HUsers", "Surname");
            DropColumn("dbo.HUsers", "Name");
        }
    }
}
