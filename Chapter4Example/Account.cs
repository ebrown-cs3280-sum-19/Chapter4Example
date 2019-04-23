using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Example {
    public class Account {
        public string Name { get; set; } // auto-implemented property
        private decimal balance; // instance variable

        public Account(string accountName, decimal initialBalance) {
            Name = accountName;
            Balance = initialBalance;
        }
        
        // Balance property with validation
        public decimal Balance {
            get {
                return balance;
            }
            private set { // can only be used within the class
                // validate blance is greater than 0.0
                if (value > 0.0m) {
                    balance = value;
                }
            }
        }

        // method that deposits only a valid amount to the balance
        public void Deposit(decimal depositAmount) {
            if (depositAmount > 0.0m) {
                Balance += depositAmount;
            }
        }
        // method that debits amount from account balance
        public void Debit(decimal debitAmount) {
            if ((Balance - debitAmount) >= 0.0m) {
                Balance -= debitAmount;
            }
        }
    }
}
