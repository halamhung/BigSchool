namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (NAME) VALUES ('DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES (NAME) VALUES ('BUSINESS')");
            Sql("INSERT INTO CATEGORIES (NAME) VALUES ('MARKERTING')");
        }
        
        public override void Down()
        {
        }
    }
}
