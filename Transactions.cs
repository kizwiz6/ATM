using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Transactions
    {
        public static void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit:");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        public static void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw:");
            double withdrawal = Double.Parse(Console.ReadLine());
            // Check if the new user has enough money.
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
            }
        }

        public static void currentBalance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance " + currentUser.getBalance());
        }
    }
}
