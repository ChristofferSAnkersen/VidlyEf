namespace VidlyEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rdChallenge3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Terminator', 1, 17-10-2018, 04-04-1993, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
