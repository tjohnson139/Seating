namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removechart : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ChartDates");
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
            
        }
    }
}
