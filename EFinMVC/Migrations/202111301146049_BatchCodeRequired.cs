namespace EFinMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BatchCodeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Batch", "BatchCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batch", "BatchCode", c => c.String());
        }
    }
}
