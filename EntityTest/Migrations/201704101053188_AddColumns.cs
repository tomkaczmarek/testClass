namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Names", "LastName", c => c.String());
            AddColumn("dbo.Names", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Names", "IsLocal", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Names", "IsLocal");
            DropColumn("dbo.Names", "BirthDate");
            DropColumn("dbo.Names", "LastName");
        }
    }
}
