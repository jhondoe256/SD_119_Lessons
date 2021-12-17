using _10_Interfaces_WorkingWithDI.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_WorkingWithDI
{
    // The idea behind our Transaction class is that it will track exchanging currency
    // We want to be able to show how our Currency objects can interact with other classes
    public class Transaction
    {
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        //when we created the transaction
        public DateTimeOffset DateOfTransaction { get; private set; }

        public decimal GetTransactionAmount() 
        {
            return _currency.Value;
        }

        public string GetTransactionType() => _currency.Name;
    }
}
