using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Project_1.Models
{
    public class Usermetadata
    {
       [Required(ErrorMessage = "Give User Name")]

        public string UserName { get; set; }
         [Required(ErrorMessage = "Give  Name")]

        public string Name { get; set; }
    [Required]
         [EmailAddress(ErrorMessage = "Give Email")]
        //[EmailAddress(t)
        public string Email { get; set; }
        [Required(ErrorMessage = "Give address")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Give Phone Number")]

        public string phoneNo { get; set; }
        [Required(ErrorMessage = "Give Password")]

        public string password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Sale_Purchase> Sale_Purchase { get; set; }
    }
}