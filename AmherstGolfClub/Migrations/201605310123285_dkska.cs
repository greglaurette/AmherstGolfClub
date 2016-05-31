namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dkska : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "ProductID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ProductID");
            DropColumn("dbo.Products", "ID");
            DropColumn("dbo.Products", "ProductCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductCode", c => c.String(nullable: false));
            AddColumn("dbo.Products", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "ProductID");
            AddPrimaryKey("dbo.Products", "ID");
        }
    }
}
