using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.Models
{
    public class Member
    {
        public int ID {get; set;}
        [Required]
        [StringLength(65)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                string name = LastName + ", " + FirstName;
                return name;
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Births")]
        public DateTime DateOfBirth { get; set; }



    }
}