﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class RestockLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductSKU { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateOfRestock { get; set; }
    }
}