namespace TalepWebUygulamasi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class huser : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "HUsers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.HUsers", newName: "Users");
        }
    }
}
