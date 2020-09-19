namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lunch451 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lunches", "LongerLunch");
            CreateIndex("dbo.Lunches", "ScheduleID");
            AddForeignKey("dbo.Lunches", "ScheduleID", "dbo.Schedules", "ScheduleID");
        }
    }
}
