namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AmherstGolfClub.DAL.GolfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AmherstGolfClub.DAL.GolfContext context)
        {
            
        }
    }
}
