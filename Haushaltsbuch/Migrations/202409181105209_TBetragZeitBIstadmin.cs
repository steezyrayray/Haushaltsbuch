namespace Haushaltsbuch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TBetragZeitBIstadmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Benutzers", "IstAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Transaktions", "Beschreibung", c => c.String());
            AddColumn("dbo.Transaktions", "Zeit", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transaktions", "Zeit");
            DropColumn("dbo.Transaktions", "Beschreibung");
            DropColumn("dbo.Benutzers", "IstAdmin");
        }
    }
}
