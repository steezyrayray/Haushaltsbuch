namespace Haushaltsbuch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategorieRework : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BenutzerKategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BenutzerId = c.Int(nullable: false),
                        KategorieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Benutzers", t => t.BenutzerId, cascadeDelete: true)
                .ForeignKey("dbo.Kategories", t => t.KategorieId, cascadeDelete: true)
                .Index(t => t.BenutzerId)
                .Index(t => t.KategorieId);
            
            AddColumn("dbo.Kategories", "HexColor", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BenutzerKategories", "KategorieId", "dbo.Kategories");
            DropForeignKey("dbo.BenutzerKategories", "BenutzerId", "dbo.Benutzers");
            DropIndex("dbo.BenutzerKategories", new[] { "KategorieId" });
            DropIndex("dbo.BenutzerKategories", new[] { "BenutzerId" });
            DropColumn("dbo.Kategories", "HexColor");
            DropTable("dbo.BenutzerKategories");
        }
    }
}
