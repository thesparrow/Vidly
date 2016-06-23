namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres Values (1,'Action')");
            Sql("INSERT INTO Genres Values (2,'Comedy')");
            Sql("INSERT INTO Genres Values (3,'Family')");
            Sql("INSERT INTO Genres Values (4,'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
