namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "HomeClub", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.AspNetUsers", "City", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "Province", c => c.String(nullable: false, maxLength: 2, fixedLength: true));
            AddColumn("dbo.AspNetUsers", "PostalCode", c => c.String(nullable: false, maxLength: 7, fixedLength: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PostalCode");
            DropColumn("dbo.AspNetUsers", "Province");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "HomeClub");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
        }
    }
}
