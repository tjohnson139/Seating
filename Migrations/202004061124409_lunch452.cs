namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lunch452 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lunches", "ScheduleID", c => c.Int());
        }
    }
}
