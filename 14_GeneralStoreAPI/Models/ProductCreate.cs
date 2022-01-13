using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    // models like this ("display" models) are only used to define the body of a request or a response
    public class ProductCreate
    {
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int QuantityInStock { get; set; }
    }
}