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

            // display myAccount's initial name (there isn't one yet);
            Console.WriteLine($"Initial name is: {myAccount.Name}");

            // prompt for and read the name then put the name in the object
            Console.Write("Enter the name: "); // prompt
            string theName = Console.ReadLine(); // read the name
            myAccount.Name = theName; // put theName in the myAccount object

            // display the name stored in the myAccount object
            Console.WriteLine($"myAccount's name is: {myAccount.Name}");
            Console.ReadKey();
        }
    }
}
