namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertLists : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BreakViews", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.BreakViews", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.DthViews", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.DthViews", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.LunchViews", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.LunchViews", "PositionID", "dbo.Positions");
            DropIndex("dbo.BreakViews", new[] { "EmployeeID" });
            DropIndex("dbo.BreakViews", new[] { "PositionID" });
            DropIndex("dbo.DthViews", new[] { "EmployeeID" });
            DropIndex("dbo.DthViews", new[] { "PositionID" });
            DropIndex("dbo.LunchViews", new[] { "EmployeeID" });
            DropIndex("dbo.LunchViews", new[] { "PositionID" });
            CreateTable(
                "dbo.ChartDates",
                c => new
                    {
                        ChartID = c.Int(nullable: false, identity: true),
                        URLDate = c.DateTime(nullable: false),
                        ChartURL = c.String(),
                    })
                .PrimaryKey(t => t.ChartID);
            
            DropTable("dbo.BreakViews");
            DropTable("dbo.DthViews");
            DropTable("dbo.LunchViews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LunchViews",
                c => new
                    {
                        LunchTime = c.DateTime(nullable: false),
                        LunchID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        PositionID = c.Int(nullable: false),
                        LongerLunch = c.Boolean(nullable: false),
                        Double = c.Boolean(nullable: false),
                        TimeEntered = c.DateTime(nullable: false),
                        EmpSent = c.Boolean(nullable: false),
                        TimeCleared = c.DateTime(),
                    })
                .PrimaryKey(t => t.LunchTime);
            
            CreateTable(
                "dbo.DthViews",
                c => new
                    {
                        DthID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        TimeEntered = c.DateTime(nullable: false),
                        TimeCleared = c.DateTime(),
                        PositionID = c.Int(nullable: false),
                        EmpSent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DthID);
            
            CreateTable(
                "dbo.BreakViews",
                c => new
                    {
                        BreakID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        TimeEntered = c.DateTime(nullable: false),
                        TimeCleared = c.DateTime(),
                        PositionID = c.Int(nullable: false),
                        EmpSent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BreakID);
            
            DropTable("dbo.ChartDates");
            CreateIndex("dbo.LunchViews", "PositionID");
            CreateIndex("dbo.LunchViews", "EmployeeID");
            CreateIndex("dbo.DthViews", "PositionID");
            CreateIndex("dbo.DthViews", "EmployeeID");
            CreateIndex("dbo.BreakViews", "PositionID");
            CreateIndex("dbo.BreakViews", "EmployeeID");
            AddForeignKey("dbo.LunchViews", "PositionID", "dbo.Positions", "PositionID", cascadeDelete: true);
            AddForeignKey("dbo.LunchViews", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.DthViews", "PositionID", "dbo.Positions", "PositionID", cascadeDelete: true);
            AddForeignKey("dbo.DthViews", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.BreakViews", "PositionID", "dbo.Positions", "PositionID", cascadeDelete: true);
            AddForeignKey("dbo.BreakViews", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
        }
    }
}
