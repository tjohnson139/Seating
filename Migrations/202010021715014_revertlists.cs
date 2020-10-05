namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertlists : DbMigration
    {
        public override void Up()
        {
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
