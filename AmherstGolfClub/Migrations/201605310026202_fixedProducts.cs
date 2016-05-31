namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedProducts : DbMigration
    {
        public override void Up()
        {

            AlterColumn("dbo.products", "ID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductCode", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Quantity", c => c.String(nullable: false));
            AddColumn("dbo.Products", "SubDepartment", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Price", c => c.String(nullable: false));
            AddColumn("dbo.Products", "ItemCategory", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Products", "ID");
        }
        
        public override void Down()
        {
            
        }
    }
}
