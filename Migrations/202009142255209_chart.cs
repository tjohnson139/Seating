namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chart : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.ChartDates");
        }
    }
}
