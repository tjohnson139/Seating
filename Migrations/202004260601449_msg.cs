namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class msg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        TimeEntered = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        MessageText = c.String(),
                        TimeToClear = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
