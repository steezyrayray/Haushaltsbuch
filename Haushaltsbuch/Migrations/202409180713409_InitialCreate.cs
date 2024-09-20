namespace Haushaltsbuch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Benutzers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Benutzername = c.String(),
                        Passwort = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transaktions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BenutzerId = c.Int(nullable: false),
                        KategorieId = c.Int(nullable: false),
                        Betrag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Benutzers", t => t.BenutzerId, cascadeDelete: true)
                .ForeignKey("dbo.Kategories", t => t.KategorieId, cascadeDelete: true)
                .Index(t => t.BenutzerId)
                .Index(t => t.KategorieId);
            
            CreateTable(
                "dbo.Kategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaktions", "KategorieId", "dbo.Kategories");
            DropForeignKey("dbo.Transaktions", "BenutzerId", "dbo.Benutzers");
            DropIndex("dbo.Transaktions", new[] { "KategorieId" });
            DropIndex("dbo.Transaktions", new[] { "BenutzerId" });
            DropTable("dbo.Kategories");
            DropTable("dbo.Transaktions");
            DropTable("dbo.Benutzers");
        }
    }
}
