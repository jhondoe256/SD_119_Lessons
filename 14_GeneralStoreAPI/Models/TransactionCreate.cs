using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class TransactionCreate
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string ProductSKU { get; set; }
        [Required]
        public int ItemCount { get; set; }
    }
}