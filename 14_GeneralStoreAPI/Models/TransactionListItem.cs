using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14_GeneralStoreAPI.Models
{
    public class TransactionListItem
    {
        public int TransactionId { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}