namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetdbagain : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "ScheduleTime", c => c.ScheduleTime());
        }
    }
}
