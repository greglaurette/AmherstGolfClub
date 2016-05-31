using AmherstGolfClub.Models;
using System.Data.Entity;

namespace AmherstGolfClub.DAL
{
    public class GolfContext:DbContext
    {
        public GolfContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rates> Rate { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentPlayers> Players { get; set; }

        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<Events> Events { get; set; }
    }
}