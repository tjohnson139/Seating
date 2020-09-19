namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpSenttodb : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lunches", "TimeCleared", c => c.DateTime());
        }
    }
}
