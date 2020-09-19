namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seating1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SeatingPages",
                c => new
                    {
                        SeatingId = c.Int(nullable: false, identity: true),
                        SeatingDate = c.DateTime(nullable: false),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.SeatingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SeatingPages");
        }
    }
}
