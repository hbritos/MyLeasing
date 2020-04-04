using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Document { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        public string Address { get; set; }

        public String FullName => $"{FirstName} {LastName}";
        public String FullNameWhitDocument => $"{FirstName} {LastName} - {Document}";

    }
}
