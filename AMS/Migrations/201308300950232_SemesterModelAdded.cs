namespace AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemesterModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemesterNumber = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Semesters", new[] { "CourseId" });
            DropForeignKey("dbo.Semesters", "CourseId", "dbo.Courses");
            DropTable("dbo.Semesters");
        }
    }
}
