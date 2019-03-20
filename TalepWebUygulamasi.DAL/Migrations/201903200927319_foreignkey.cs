namespace TalepWebUygulamasi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taleps", "TalebiYapan", c => c.String(maxLength: 128));
            AddColumn("dbo.Taleps", "Degerlendirildimi", c => c.Boolean(nullable: false));
            AddColumn("dbo.Taleps", "TalepDegerlendirmesi", c => c.String());
            AddColumn("dbo.Taleps", "olumluOlumsuz", c => c.Boolean(nullable: false));
            AddColumn("dbo.Taleps", "DegerlendirmeZamani", c => c.String());
            CreateIndex("dbo.Taleps", "TalebiYapan");
            AddForeignKey("dbo.Taleps", "TalebiYapan", "dbo.HUsers", "UserName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Taleps", "TalebiYapan", "dbo.HUsers");
            DropIndex("dbo.Taleps", new[] { "TalebiYapan" });
            DropColumn("dbo.Taleps", "DegerlendirmeZamani");
            DropColumn("dbo.Taleps", "olumluOlumsuz");
            DropColumn("dbo.Taleps", "TalepDegerlendirmesi");
            DropColumn("dbo.Taleps", "Degerlendirildimi");
            DropColumn("dbo.Taleps", "TalebiYapan");
        }
    }
}
