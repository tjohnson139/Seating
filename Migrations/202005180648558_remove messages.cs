namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removemessages : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Messages");
        }
        
        public override void Down()
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
    }
}
