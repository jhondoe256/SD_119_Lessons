using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        [Required]
        [ForeignKey(nameof(Product))]
        public string ProductSKU { get; set; }
        [Required]
        public int ItemCount { get; set; }
        [Required]
        public DateTime DateOfTransaction { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}