namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Quantity", c => c.String());
            AlterColumn("dbo.Products", "ItemCategory", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ItemCategory", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Quantity", c => c.String(nullable: false));
        }
    }
}
