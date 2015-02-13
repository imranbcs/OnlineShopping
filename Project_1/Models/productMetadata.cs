using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class productMetadata
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Give Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Give Product Price")]
        public int ProductPrice { get; set; }
        [Required(ErrorMessage = "Give Product Catagory")]
        public string ProductCatagery { get; set; }
       // [Required(ErrorMessage = "Give Product Name")]
        public string ProductImage { get; set; }
    }
}