using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.Models
{
    public class Rates
    {
        [Required]
        public int RatesID { get; set; }

        [Required]        
        public string Description { get; set; }
        
        public decimal Rate { get; set; }

        public string TimeFrame { get; set; }
    }
}