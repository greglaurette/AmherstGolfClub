namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ashdfasi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.products", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
