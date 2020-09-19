namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clearlunch : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lunches", "TimeCleared");
        }
    }
}
