namespace VidlyEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataOfBirthToJohn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth = '04/01/1994' WHERE Name = 'John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
