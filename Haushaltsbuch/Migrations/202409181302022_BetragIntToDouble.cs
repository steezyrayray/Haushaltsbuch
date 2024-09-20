namespace Haushaltsbuch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetragIntToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transaktions", "Betrag", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transaktions", "Betrag", c => c.Int(nullable: false));
        }
    }
}
