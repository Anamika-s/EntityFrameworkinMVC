namespace EFinMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedUsers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "ComparePassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ComparePassword", c => c.String(nullable: false));
        }
    }
}
