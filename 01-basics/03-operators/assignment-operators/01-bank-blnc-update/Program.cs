using System;

namespace _01_bank_blnc_update
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start with balance = 1000. Deposit 500, withdraw 200, then apply a 10% interest using *= 1.1

            double balance = 1000;

            Console.WriteLine($"Dear Customer,\n  Your account was created successfully.\n  Your Initial balance: rs {balance}/-");

            Console.WriteLine($"\nAmount credited: rs. {500}/- to your account.\nYour total balance is rs. {balance += 500}/-");

            Console.WriteLine($"\nAmount debited: rs. {200}/- from your account.\nYour total balance is rs. {balance -= 200}/-");

            Console.WriteLine("\nThank you for choosing our bank.\nFor being our best customer, we will be giving you a 10% interest on your balance.\nWe hope you will continue to choose our bank.");

            Console.WriteLine($"\nInterest Credited: rs. {balance *= 1.1:F2}/-");
        }
    }
}
