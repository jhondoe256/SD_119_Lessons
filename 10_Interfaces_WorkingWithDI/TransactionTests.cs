using _10_Interfaces_WorkingWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_Interfaces_WorkingWithDI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }

        [TestInitialize]
        public void Arrange() 
        {
            _debt = 9000.01m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(315.52m));

            decimal expectedDebt = 9000.01m - 316.52m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();

            var ePayment = new ElectronicPayment(243.71m);

            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);

            //see what kind of transactions that each one above is using...
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            //Assert
            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Eletronic Payment", secondTransaction.GetTransactionType());

            Assert.AreEqual(243.71m, secondTransaction.GetTransactionAmount());

        }
        // Let's show another example, this time with a few more Transactions
        // Here's another quick example that shows a list of Transactions being made
        // We can call the same method regardless of what has been passed into the constructor
        [TestMethod]
        public void MoreExamples()
        {

            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Dime()),
                new Transaction(new Dollar()),
                new Transaction(new Penny())
            };

            //loop through each transaction and Print the Transaction Type, amount ,and date
            foreach (var transaction in list)
            {
                var type = transaction.GetTransactionType();
                var amount = transaction.GetTransactionAmount();

                Console.WriteLine($"{type} ${amount} {transaction.DateOfTransaction}");
            }
        }
    }
}
