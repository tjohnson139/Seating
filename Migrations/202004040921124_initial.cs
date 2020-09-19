namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breaks",
                c => new
                    {
                        BreakID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        TimeEntered = c.DateTime(nullable: false),
                        TimeCleared = c.DateTime(),
                    })
                .PrimaryKey(t => t.BreakID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DisplayName = c.String(),
                        NotActive = c.Boolean(nullable: false),
                        Force = c.Boolean(nullable: false),
                        ScheduleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Schedules", t => t.ScheduleID, cascadeDelete: true)
                .Index(t => t.ScheduleID);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleID = c.Int(nullable: false, identity: true),
                        ScheduleTime = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleID);
            
            CreateTable(
                "dbo.Dths",
                c => new
                    {
                        DthID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        TimeEntered = c.DateTime(nullable: false),
                        TimeCleared = c.DateTime(),
                    })
                .PrimaryKey(t => t.DthID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Lunches",
                c => new
                    {
                        LunchID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        LunchTime = c.DateTime(nullable: false),
                        PositionID = c.Int(),
                        ScheduleID = c.Int(),
                        TimeEntered = c.Int(),
                    })
                .PrimaryKey(t => t.LunchID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionID)
                .ForeignKey("dbo.Schedules", t => t.ScheduleID)
                .Index(t => t.EmployeeID)
                .Index(t => t.PositionID)
                .Index(t => t.ScheduleID)
                .Index(t => t.TimeEntered);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Lunches", "ScheduleID", "dbo.Schedules");
            DropForeignKey("dbo.Lunches", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.Lunches", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Dths", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Breaks", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "ScheduleID", "dbo.Schedules");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Lunches", new[] { "ScheduleID" });
            DropIndex("dbo.Lunches", new[] { "PositionID" });
            DropIndex("dbo.Lunches", new[] { "EmployeeID" });
            DropIndex("dbo.Dths", new[] { "EmployeeID" });
            DropIndex("dbo.Employees", new[] { "ScheduleID" });
            DropIndex("dbo.Breaks", new[] { "EmployeeID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Positions");
            DropTable("dbo.Lunches");
            DropTable("dbo.Dths");
            DropTable("dbo.Schedules");
            DropTable("dbo.Employees");
            DropTable("dbo.Breaks");
        }
    }
}
