namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetimesenttobool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Breaks", "EmpSent", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dths", "EmpSent", c => c.Boolean(nullable: false));
            AddColumn("dbo.Lunches", "EmpSent", c => c.Boolean(nullable: false));
            DropColumn("dbo.Breaks", "TimeSent");
            DropColumn("dbo.Dths", "TimeSent");
            DropColumn("dbo.Lunches", "TimeSent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lunches", "TimeSent", c => c.DateTime());
            AddColumn("dbo.Dths", "TimeSent", c => c.DateTime());
            AddColumn("dbo.Breaks", "TimeSent", c => c.DateTime());
            DropColumn("dbo.Lunches", "EmpSent");
            DropColumn("dbo.Dths", "EmpSent");
            DropColumn("dbo.Breaks", "EmpSent");
        }
    }
}
