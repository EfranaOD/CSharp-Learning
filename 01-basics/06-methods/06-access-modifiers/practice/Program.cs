using System;

namespace practice
{
    internal class Program
    {
        class BankAccount
        {
            public double balance = 10000;
            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Deposit failed! Invalid amount.");
                    return;
                }

                balance += amount + CalculateInterest();
                Console.WriteLine($"Deposit successful of amount: {amount}");
                DisplayBalance();
            }
            public void Withdraw(double amount)
            {
                if (amount <= 0 || balance - amount < 0)
                {
                    Console.WriteLine("Withdrawal failed! Insufficient funds or invalid amount.");
                    return;
                }

                balance -= amount;
                Console.WriteLine($"Withdrawal successful of amount: {amount}");
                DisplayBalance();
            }
            private double CalculateInterest()
            {
                double interest = (balance * 1.5) / 100;
                return interest;
            }
            public void DisplayBalance()
            {
                Console.WriteLine($"Total balance: {balance}");
            }
        }
        static void Main(string[] args)
        {
            //Create class BankAccount.
            //    Public method: Deposit(double amount)
            //    Public method: Withdraw(double amount)
            //    Private method: CalculateInterest() → called internally only.
            //Demonstrate how access modifiers control visibility.

            //BankAccount account = new BankAccount();

            //Console.Write("Enter amount for withdrawal: ");
            //if (double.TryParse(Console.ReadLine(), out double withdrawAmt))
            //    account.Withdraw(withdrawAmt);

            //Console.Write("Enter amount for deposit: ");
            //if (double.TryParse(Console.ReadLine(), out double depositAmt))
            //    account.Deposit(depositAmt);

            string name = "Efrana";
            DateTime date = DateTime.Now;
            string pattern = $"Welcome {name}, today is {date:T}";
            string result = $"{pattern}";

            Console.WriteLine(result);
        }
    }
}
