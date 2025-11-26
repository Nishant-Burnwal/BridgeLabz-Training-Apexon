using System;

namespace CSharp_Fundaments.OOPS
{
    class Account
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine("Balance: " + account.GetBalance());
        }
    }
}
