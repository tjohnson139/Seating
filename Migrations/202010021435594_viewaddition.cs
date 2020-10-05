namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewaddition : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ChartDates",
                c => new
                    {
                        ChartID = c.Int(nullable: false, identity: true),
                        URLDate = c.DateTime(nullable: false),
                        ChartURL = c.String(),
                    })
                .PrimaryKey(t => t.ChartID);
            
            DropForeignKey("dbo.LunchViews", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.LunchViews", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.DthViews", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.DthViews", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.BreakViews", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.BreakViews", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.LunchViews", new[] { "PositionID" });
            DropIndex("dbo.LunchViews", new[] { "EmployeeID" });
            DropIndex("dbo.DthViews", new[] { "PositionID" });
            DropIndex("dbo.DthViews", new[] { "EmployeeID" });
            DropIndex("dbo.BreakViews", new[] { "PositionID" });
            DropIndex("dbo.BreakViews", new[] { "EmployeeID" });
            DropTable("dbo.LunchViews");
            DropTable("dbo.DthViews");
            DropTable("dbo.BreakViews");
        }
    }
}
