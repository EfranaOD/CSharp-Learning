using System;

namespace MiniATMSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user to enter their 4-digit PIN.
            //  If correct → continue.
            //  If wrong → print “Invalid PIN” and exit.
            //Once logged in, display a menu (via switch):
            //  1. Balance Inquiry
            //  2.Withdraw
            //  3.Deposit
            //  4.Exit
            //Balance Inquiry → Show current balance.
            //  Start with a fixed balance (e.g., 5000).
            //Withdraw → Ask for amount.
            //  If amount > balance → “Insufficient funds!”
            //  If amount <= balance → deduct and show new balance.
            //Deposit → Ask for amount, add it, show new balance.
            //Exit → Print “Thank you, visit again.”
            //Invalid menu choice → handled with default.

            double balance = 5000.00d;

            Console.Write("Enter your 4-digit PIN: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInputPIN);
            if (!success)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            if ( userInputPIN == 1234 )
            {
                Console.WriteLine("\n1. Balance Inquiry\n2. Withdraw\n3. Deposit\n4. Exit\n");
                Console.WriteLine("Enter your choice(1-4):");
                bool successOne = int.TryParse(Console.ReadLine(), out int userMenuChoice);
                if (!successOne)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                switch (userMenuChoice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance: {balance:C}");
                        break;

                    case 2:
                        Console.Write("Enter the amount to withdraw: ");
                        bool successTwo = int.TryParse(Console.ReadLine(), out int userWithdrawInput);
                        if (!successTwo) { Console.WriteLine("Invalid input!"); return; }
                        if(userWithdrawInput > balance)
                        {
                            Console.WriteLine("Insufficient funds!");
                        }
                        else if(userWithdrawInput <= 0)
                        {
                            Console.WriteLine($"Invalid withdrawal amount\nYour current balance: {balance:C}");
                        }
                        else if(userWithdrawInput <= balance)                             
                        {
                            balance -= userWithdrawInput;
                            Console.WriteLine($"Withdrawal success!\nYour current balance: {balance:C}");
                        }
                        else
                        {
                            Console.WriteLine($"Withdrawal failed\nYour current balance: {balance:C}");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the amount to deposit: ");
                        bool successThree = int.TryParse(Console.ReadLine(), out int userDepositInput);
                        if (!successThree) { Console.WriteLine("Invalid input!"); return; }
                        if (userDepositInput <= 0)
                        {
                            Console.WriteLine("Invalud deposit amount");
                        }
                        else
                        {
                            balance += userDepositInput;
                            Console.WriteLine($"Deposit successful!\nYour current balance: {balance:C}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank you for choosing our banks services! Visit again.");
                        break;

                    default:
                        Console.WriteLine("Invalid menu choice");
                        break;
                }
                Console.WriteLine("\nTransaction complete. Program exiting...");
            }
            else
            {
                Console.WriteLine("Invalid PIN!");
            }
        }
    }
}
