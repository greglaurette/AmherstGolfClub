using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }        
        public string SubDepartment{ get; set; } 
        public string ItemCategory { get; set; }
        
        
    }
}