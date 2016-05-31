namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEventType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        EventTypeID = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EventTypeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventTypes");
        }
    }
}
