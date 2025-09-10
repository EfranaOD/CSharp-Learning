using System;

namespace _02Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables: a = 10, b = 5, op = '+' (char).
            //Use switch on op to perform:
            //  + → add
            //  - → subtract
            //  * → multiply
            //  / → divide
            //Print the result. If invalid operator → print "Unknown operation".

            Console.Write("Enter first number: ");
            bool successOne = int.TryParse(Console.ReadLine(), out int inputOne);
            Console.Write("Enter second number: ");
            bool successTwo = int.TryParse(Console.ReadLine(), out int inputTwo);

            Console.Write("Choose an operator(+, -, *, /): ");
            bool success = char.TryParse(Console.ReadLine(), out char op);

            if (!success || !successOne || !successTwo)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{inputOne} + {inputTwo} = {inputOne + inputTwo}");
                    break;

                case '-':
                    Console.WriteLine($"{inputOne} - {inputTwo} = {inputOne - inputTwo}");
                    break;

                case '*':
                    Console.WriteLine($"{inputOne} * {inputTwo} = {inputOne * inputTwo}");
                    break;

                case '/':
                    if(inputTwo != 0)
                    {
                        double divOnUserInputs = (double)inputOne / (double)inputTwo;
                        Console.WriteLine($"{inputOne} / {inputTwo} = {divOnUserInputs:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                        break;

                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        }
    }
}
