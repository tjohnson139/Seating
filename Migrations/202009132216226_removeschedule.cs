namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeschedule : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleID = c.Int(nullable: false, identity: true),
                        ScheduleTime = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleID);
            
            AddColumn("dbo.Employees", "ScheduleID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "ScheduleID");
            AddForeignKey("dbo.Employees", "ScheduleID", "dbo.Schedules", "ScheduleID", cascadeDelete: true);
        }
    }
}
