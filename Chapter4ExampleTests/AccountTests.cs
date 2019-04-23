using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter4Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Example.Tests {
    [TestClass()]
    public class AccountTests {
        
        [TestMethod()]
        public void DepositTest() {
            Account myAccount = new Account("test account", 0.0m);
            decimal amount = 5.05m;
            myAccount.Deposit(amount);

            Assert.AreEqual(myAccount.Balance, amount);
        }

        [TestMethod()]
        public void DebitTest() {
            decimal startBalance = 10.00m;
            Account myAccount = new Account("test account", startBalance);
            decimal amount = 5.00m;
            myAccount.Debit(amount);

            Assert.AreEqual(myAccount.Balance, startBalance - amount);
        }
    }
}