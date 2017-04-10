namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Names", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Names", "LastName", c => c.String());
        }
    }
}
