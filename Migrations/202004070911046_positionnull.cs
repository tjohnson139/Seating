namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class positionnull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lunches", "PositionID", "dbo.Positions");
            DropIndex("dbo.Lunches", new[] { "PositionID" });
            AlterColumn("dbo.Lunches", "PositionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Lunches", "PositionID");
            AddForeignKey("dbo.Lunches", "PositionID", "dbo.Positions", "PositionID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lunches", "PositionID", "dbo.Positions");
            DropIndex("dbo.Lunches", new[] { "PositionID" });
            AlterColumn("dbo.Lunches", "PositionID", c => c.Int());
            CreateIndex("dbo.Lunches", "PositionID");
            AddForeignKey("dbo.Lunches", "PositionID", "dbo.Positions", "PositionID");
        }
    }
}
