using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class ProductEdit
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}