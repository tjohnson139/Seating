namespace Seating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0405 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Force", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Force", c => c.Boolean(nullable: false));
        }
    }
}
