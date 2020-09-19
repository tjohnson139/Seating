namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seating : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SeatingPages");
        }
        
        public override void Down()
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
    }
}
