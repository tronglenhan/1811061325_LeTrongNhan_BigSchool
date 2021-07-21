namespace _1811061325_LeTrongNhan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Followings", "IsCanceled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Followings", "IsCanceled", c => c.Boolean(nullable: false));
        }
    }
}
