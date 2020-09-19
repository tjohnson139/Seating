namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lunchentered : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lunches", "TimeEntered");
        }
    }
}
