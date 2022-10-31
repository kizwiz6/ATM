using System;

namespace ATM
{
    public class MenuOptions
    {
        public static void printMenuOptions()
        {
            Console.WriteLine("Please choose from one of the following options:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }
    }
}
