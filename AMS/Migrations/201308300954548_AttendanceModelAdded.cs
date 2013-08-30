namespace AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttendanceModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        IsPresent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Attendances", new[] { "StudentId" });
            DropForeignKey("dbo.Attendances", "StudentId", "dbo.Students");
            DropTable("dbo.Attendances");
        }
    }
}
