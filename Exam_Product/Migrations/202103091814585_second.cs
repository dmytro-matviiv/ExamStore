namespace Exam_Product.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb1Cloth", "Price", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb1Cloth", "Price", c => c.Int(nullable: false));
        }
    }
}
