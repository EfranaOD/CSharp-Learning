using System;

namespace _02BankWithdrawal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables: balance = 5000, withdraw = 2000.
            //First check if withdraw <= balance.
            //  If true → then check if withdraw <= 3000.
            //    If true → print "Withdrawal successful".
            //    Else → print "Withdrawal limit exceeded".
            //  Else → print "Insufficient balance".

            double balance = 5000, withdraw;

            Console.WriteLine("Amount to withdraw?");
            bool success = double.TryParse(Console.ReadLine(), out withdraw);

            if (!success)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if ( withdraw <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount!");
                return;
            }

            if ( withdraw <= balance )
            {
                if(withdraw <= 3000)
                {
                    balance -= withdraw;
                    Console.WriteLine($"Withdrawal successful!\nYour current balance {balance}");
                }
                else
                {
                    Console.WriteLine("Withdrawal limit exceeded!");
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}
