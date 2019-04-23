using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Example {
    class Program {
        static void Main(string[] args) {
            // create an Account object and assign it to myAccount
            Account myAccount = new Account("John Doe", 0.0m);

            Console.WriteLine($"Initial name is: {myAccount.Name}");
            Console.WriteLine($"Initial balance is: {myAccount.Balance}");

            // prompt for and read the name then put the name in the object
            Console.Write("Enter the name: "); // prompt
            string theName = Console.ReadLine(); // read the name
            myAccount.Name = theName; // put theName in the myAccount object
            Console.WriteLine("Enter Deposit Amount: ");
            decimal theAmount = decimal.Parse(Console.ReadLine());
            myAccount.Deposit(theAmount);

            // display the name stored in the myAccount object
            Console.WriteLine($"myAccount's name is: {myAccount.Name}");
            Console.WriteLine($"myAccount's Balance is: {myAccount.Balance}");
            Console.ReadKey();
        }
    }
}
