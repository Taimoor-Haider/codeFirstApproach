﻿namespace CodeFirstWithExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TitlePropertyChangedToNameInCourses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable:true)); 
            Sql("UPDATE Courses SET Name=Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            Sql("UPDATE Courses SET Title=Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
