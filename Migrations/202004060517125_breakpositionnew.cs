namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class breakpositionnew : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Breaks", "PositionID", "dbo.Positions");
            DropIndex("dbo.Breaks", new[] { "PositionID" });
            DropColumn("dbo.Breaks", "PositionID");
        }
    }
}
