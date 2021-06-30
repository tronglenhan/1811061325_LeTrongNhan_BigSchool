namespace _1811061325_LeTrongNhan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCancled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCancled");
        }
    }
}
