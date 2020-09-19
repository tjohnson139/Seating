namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class timesentvalues : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lunches", "TimeCleared");
            DropColumn("dbo.Lunches", "TimeSent");
            DropColumn("dbo.Dths", "TimeSent");
            DropColumn("dbo.Breaks", "TimeSent");
        }
    }
}
