using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class Product
    {
        [Key]
        public string SKU { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int QuantityInStock { get; set; }
        public bool IsInStock
        {
            get
            {
                return QuantityInStock > 0;
            }
        }
    }
}