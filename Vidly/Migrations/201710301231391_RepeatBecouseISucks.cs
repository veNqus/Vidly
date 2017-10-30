namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepeatBecouseISucks : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "BirthdayDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BirthdayDate", c => c.DateTime(nullable: false));
        }
    }
}
