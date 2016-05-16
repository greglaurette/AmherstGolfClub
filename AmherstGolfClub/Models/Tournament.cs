using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.Models
{
    public class Tournament
    {
        public virtual ICollection<TournamentPlayers> TournamentPlayers { get; set; }

        public int TournamentID { get; set; }

        public string TournamentName { get; set; }

        public DateTime TournamentDate { get; set; }

    }
}