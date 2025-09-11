using System;

namespace PatternGeneratorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nPATTERN GENERATOR");
                Console.Write("\n1. Square Grid\n2. Right-Angled Triangle\n3. Multiplication Table\n4. Pyramid of Stars\n5. Filled Hourglass\n6. Hollow Hourglass\n7. Filled Butterfly\n8. Hollow Butterfly\n9. Exit\n\nEnter your choice(1-9): ");
                bool success = int.TryParse(Console.ReadLine(), out int userChoiceInput);
                if (!success) { Console.WriteLine("Invalid input! Try again."); continue; }

                switch (userChoiceInput)
                {
                    case 1:
                        Console.Write("\nEnter the grid size: ");
                        bool gridSuccess = int.TryParse(Console.ReadLine(), out int gridUserSizeChoice);
                        if (!gridSuccess) { Console.WriteLine("Invalid size. Try again."); continue; }

                        for(int row = 1; row <= gridUserSizeChoice; row++)
                        {
                            for(int col = 1; col <= gridUserSizeChoice; col++)
                            {
                                Console.Write($"{col} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.Write("Enter the height for triangle: ");
                        bool rightAngleSuccess = int.TryParse(Console.ReadLine(), out int rightAngleUserHeightChoice);
                        if (!rightAngleSuccess) { Console.WriteLine("Invalid input! Try again."); continue; }

                        for (int row = 1; row <= rightAngleUserHeightChoice; row++)
                        {
                            for (int col = 1; col <= row; col++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.Write("Enter upto which number you want the table: ");
                        bool multiTableSuccess = int.TryParse(Console.ReadLine(), out int multiTableUserSizeChoice);
                        if (!multiTableSuccess) { Console.WriteLine("Invalid input! Try again."); continue; }

                        for (int row = 1; row <= multiTableUserSizeChoice; row++)
                        {
                            for (int col = 1; col <= multiTableUserSizeChoice; col++)
                            {
                                Console.Write($"{row * col,3} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        Console.Write("Enter the height of the Pyramid: ");
                        bool pyramidInputSuccess = int.TryParse(Console.ReadLine(), out int pyramidHeightChoice);
                        if (!pyramidInputSuccess) { Console.WriteLine("Invalid size! Try again."); continue; }

                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int row = 1; row <= pyramidHeightChoice; row++)
                        {
                            for(int space = 1; space <= pyramidHeightChoice - row; space++)
                            {
                                Console.Write(" ");
                            }
                            for(int star = 1; star <= row * 2 - 1; star++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                        break;

                    case 5:
                        Console.Write("Enter the height of the hourglass: ");
                        bool hourglassInputSuccess = int.TryParse(Console.ReadLine(), out int hourglassHeightChoice);
                        if (!hourglassInputSuccess) { Console.WriteLine("Invalid input! Try again."); continue; }

                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int row = 1; row <= hourglassHeightChoice; row++)
                        {
                            for (int space = 1; space <= row - 1; space++)
                            {
                                Console.Write(" ");
                            }
                            for (int star = 1; star <= (hourglassHeightChoice * 2 - 1) - (2 * (row - 1)); star++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int row = 2; row <= hourglassHeightChoice; row++)
                        {
                            for (int space = 1; space <= hourglassHeightChoice - row; space++)
                            {
                                Console.Write(" ");
                            }
                            for (int star = 1; star <= row * 2 - 1; star++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                        break;

                    case 6:
                        Console.Write("Enter the height of the hollow hourglass: ");
                        bool hollowHourglassSuccess = int.TryParse(Console.ReadLine(), out int hollowHourglassHeightChoice);
                        if (!hollowHourglassSuccess) { Console.WriteLine("Invalid input! Try again."); continue; }

                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int row = 1; row <= hollowHourglassHeightChoice; row++)
                        {
                            for (int space = 1; space <= row - 1; space++)
                            {
                                Console.Write(" ");
                            }
                            for (int star = 1; star <= (hollowHourglassHeightChoice * 2 - 1) - (2 * (row - 1)); star++)
                            {
                                if(row == 1 || star == 1 || star == (hollowHourglassHeightChoice * 2 - 1) - (2 * (row - 1)))
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        for (int row = 2; row <= hollowHourglassHeightChoice; row++)
                        {
                            for (int space = 1; space <= hollowHourglassHeightChoice - row; space++)
                            {
                                Console.Write(" ");
                            }
                            for (int star = 1; star <= row * 2 - 1; star++)
                            {
                                if(row == hollowHourglassHeightChoice || star == 1 || star == row * 2 - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                        break;

                    case 7:
                        Console.Write("Enter the height of the butterfly: ");
                        bool butterflyInputSuccess = int.TryParse(Console.ReadLine(), out int butterflyHeightChoice);
                        if (!butterflyInputSuccess) { Console.WriteLine("Invalid input! Try again."); continue; }

                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int row = 1; row <= butterflyHeightChoice; row++)
                        {
                            for(int leftWingStar = 1; leftWingStar <= row; leftWingStar++)
                            {
                                Console.Write("*");
                            }
                            for(int midSpace = 1; midSpace <= 2 * (butterflyHeightChoice - row) - 1; midSpace++)
                            {
                                Console.Write(" ");
                            }
                            if(row == butterflyHeightChoice)
                            {

                                for (int rightWingStar = 1; rightWingStar <= row - 1; rightWingStar++)
                                {
                                    Console.Write("*");
                                }
                            }
                            else
                            {
                                for (int rightWingStar = 1; rightWingStar <= row; rightWingStar++)
                                {
                                    Console.Write("*");
                                }
                            }
                                Console.WriteLine();
                        }
                        for (int row = butterflyHeightChoice - 1; row >= 1; row--)
                        {
                            for (int leftWingStar = 1; leftWingStar <= row; leftWingStar++)
                            {
                                Console.Write("*");
                            }
                            for (int midSpace = 1; midSpace <= 2 * (butterflyHeightChoice - row) - 1; midSpace++)
                            {
                                Console.Write(" ");
                            }
                            for (int rightWingStar = 1; rightWingStar <= row; rightWingStar++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                        break;

                    case 8:
                        Console.Write("Enter the height of the hollow butterfly: ");
                        bool hollowButterflySuccess = int.TryParse(Console.ReadLine(), out int hollowButterflyHeight);
                        if (!hollowButterflySuccess) { Console.WriteLine("Invalid input! Try again."); continue; }

                        for (int row = 1; row <= hollowButterflyHeight; row++)
                        {
                            for (int leftWingStar = 1; leftWingStar <= row; leftWingStar++)
                            {
                                if(row == leftWingStar || leftWingStar == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            for (int midSpace = 1; midSpace <= 2 * (hollowButterflyHeight - row) - 1; midSpace++)
                            {
                                Console.Write(" ");
                            }
                            int rightWingCount = (row == hollowButterflyHeight) ? row - 1 : row;

                            for (int rightWingStar = 1; rightWingStar <= rightWingCount; rightWingStar++)
                            {
                                if (rightWingStar == 1 || rightWingStar == rightWingCount) Console.Write("*");
                                else Console.Write(" ");
                            }

                            Console.WriteLine();
                            Console.ResetColor();
                        }
                        for (int row = hollowButterflyHeight - 1; row >= 1; row--)
                        {
                            for (int leftWingStar = 1; leftWingStar <= row; leftWingStar++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (leftWingStar == 1 || leftWingStar == row) Console.Write("*");
                                else Console.Write(" ");

                            }
                            for (int midSpace = 1; midSpace <= 2 * (hollowButterflyHeight - row) - 1; midSpace++)
                            {
                                Console.Write(" ");
                            }
                            for (int rightWingStar = 1; rightWingStar <= row; rightWingStar++)
                            {
                                if (rightWingStar == 1 || rightWingStar == row) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                            Console.ResetColor();
                        }
                        break;

                    case 9:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid menu choice! Try again.");
                        break;
                }


            } while (true);
        }
    }
}
