namespace Exam_Product.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb1Cloth", "Details", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb1Cloth", "Details");
        }
    }
}
