using _10_Interfaces_WorkingWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {

        [TestMethod]
        public void PennyTests()
        {
            ICurrency penny = new Penny();

            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }

        [TestMethod]
        public void DollarTests()
        {
            ICurrency dollar = new Dollar();

            Assert.AreEqual(1.00m, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }

        [TestMethod]
        public void DimeTests()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual(0.10m, dime.Value);
            Assert.AreEqual("Dime", dime.Name);
        }

        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(1.50)]
        [DataRow(19)]
        public void EPaymentTests(double value)
        {
            //have to make conversion to make this method work!
            decimal convertedValue = Convert.ToDecimal(value);

            //we can execute our Epayment-> one by one the dataRow value is pass through here
            var ePayment = new ElectronicPayment(convertedValue);

            //Now we can make an Assertion....
            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Eletronic Payment", ePayment.Name);
        }

    }
}
