namespace _1811061325_LeTrongNhan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCanceled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCancled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsCancled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
