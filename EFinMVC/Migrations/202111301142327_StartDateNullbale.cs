namespace EFinMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartDateNullbale : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Batch", "StartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batch", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
