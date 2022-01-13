using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class ProductRestock
    {
        [Required]
        public int Quantity { get; set; }
    }
}