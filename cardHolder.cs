using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class cardHolder
    {
        public string CardNum { get; set; }

        public int Pin { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            CardNum = cardNum;
            Pin = pin;
            FirstName = firstName;
            LastName = lastName;
            this.balance = balance;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }


    }
}
