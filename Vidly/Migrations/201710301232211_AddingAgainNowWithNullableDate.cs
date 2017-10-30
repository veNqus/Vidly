namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAgainNowWithNullableDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthdayDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthdayDate");
        }
    }
}
