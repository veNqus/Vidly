namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES ('Familly') ");
            Sql("INSERT INTO Genres(Name) VALUES ('Horror') ");
            Sql("INSERT INTO Genres(Name) VALUES ('Romantic') ");
            Sql("INSERT INTO Genres(Name) VALUES ('Comedy') ");
        }
        
        public override void Down()
        {
        }
    }
}
