using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.Models
{
    public class Product
    {
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string SubDepartment { get; set; }

        [Required]
        public string ItemCategory { get; set; }
    }
}