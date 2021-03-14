namespace Exam_Product.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seven : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb1Cloth", "Color", c => c.String(nullable: false));
            DropColumn("dbo.tb1Cloth", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb1Cloth", "Description", c => c.String(nullable: false));
            DropColumn("dbo.tb1Cloth", "Color");
        }
    }
}
