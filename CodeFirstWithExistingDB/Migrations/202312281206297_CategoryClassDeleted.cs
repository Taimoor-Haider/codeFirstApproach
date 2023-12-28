namespace CodeFirstWithExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryClassDeleted : DbMigration
    {
        public override void Up()
        {
            CreateTable(
             "dbo._Categories",
             c => new
             {
                 Id = c.Int(nullable: false, identity: true),
                 CategoryName = c.String(),
             })
             .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Categories (CategoryName) SELECT CategoryName FROM Categories");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Categories (CategoryName) SELECT CategoryName FROM _Categories");
            DropTable("dbo._Categories");
            
        }
    }
}
