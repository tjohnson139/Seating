namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dthposition : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dths", "PositionID", "dbo.Positions");
            DropIndex("dbo.Dths", new[] { "PositionID" });
            DropColumn("dbo.Dths", "PositionID");
        }
    }
}
