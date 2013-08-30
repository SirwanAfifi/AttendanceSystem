namespace AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesMadeinSemesterModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Semesters", "NumberOfSemesters", c => c.Int(nullable: false));
            DropColumn("dbo.Semesters", "SemesterNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Semesters", "SemesterNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Semesters", "NumberOfSemesters");
        }
    }
}
