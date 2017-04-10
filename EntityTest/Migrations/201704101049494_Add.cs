namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Names",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Names_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Names", t => t.Names_ID)
                .Index(t => t.Names_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Names_ID", "dbo.Names");
            DropIndex("dbo.Subjects", new[] { "Names_ID" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Names");
        }
    }
}
