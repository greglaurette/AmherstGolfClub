namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjustEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventsID = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventsID)
                .ForeignKey("dbo.EventTypes", t => t.Type, cascadeDelete: true)
                .Index(t => t.Type);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Type", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "Type" });
            DropTable("dbo.Events");
        }
    }
}
