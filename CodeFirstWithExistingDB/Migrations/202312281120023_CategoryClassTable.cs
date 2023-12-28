namespace CodeFirstWithExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories VALUES (1,'WEB Development')");
            Sql("INSERT INTO Categories VALUES (2,'Machine Learning')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
