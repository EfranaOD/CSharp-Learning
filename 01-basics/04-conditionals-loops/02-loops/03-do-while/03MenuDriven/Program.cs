using System;

namespace _03MenuDriven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple menu:
            //  1. Say Hello
            //  2. Show Date
            //  3. Exit
            //Use a do-while loop so the menu shows repeatedly until the user chooses Exit.

            int userMenuChoice;
            do
            {
                Console.Write("\nMenu\n1. Say Hello\n2. Show Date\n3. Exit\n\nYour Choice: ");
                bool success = int.TryParse(Console.ReadLine(), out userMenuChoice);
                if (!success) { Console.WriteLine("\nInvalid input!\nTry again..."); continue; }

                switch (userMenuChoice)
                {
                    case 1:
                        Console.WriteLine("\nHello! Nice to meet you. Have a Nice Day!");
                        break;

                    case 2:
                        Console.WriteLine($"\nSo today's date is {DateTime.Now.ToShortDateString()}");
                        break;

                    case 3:
                        Console.WriteLine("\nExiting...");
                        break;

                    default:
                        Console.WriteLine("\nInvalid menu choice, try again.");
                        break;
                }
            } while (userMenuChoice != 3);
        }
    }
}
