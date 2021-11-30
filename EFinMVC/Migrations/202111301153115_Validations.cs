namespace EFinMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batch", "Count", c => c.Int(nullable: false));
            AlterColumn("dbo.Batch", "BatchCode", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Batch", "Course", c => c.String(nullable: false));
            AlterColumn("dbo.Batch", "StartDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batch", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Batch", "Course", c => c.String());
            AlterColumn("dbo.Batch", "BatchCode", c => c.String(nullable: false));
            DropColumn("dbo.Batch", "Count");
        }
    }
}
