using System;

namespace _01_compare_nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take two inputs, print all relational comparisons.

            Console.Write("enter anything: ");
            string userInput1 = Console.ReadLine();
            Console.Write("enter anything again:");
            string userInput2 = Console.ReadLine();

            if (int.TryParse(userInput1, out int num1) && int.TryParse(userInput2, out int num2))
            {
                Console.WriteLine($"Comparisons for {num1} == {num2}: {num1 == num2}");
                Console.WriteLine($"Comparisons for {num1} != {num2}: {num1 != num2}");
                Console.WriteLine($"Comparisons for {num1} < {num2}: {num1 < num2}");
                Console.WriteLine($"Comparisons for {num1} > {num2}: {num1 > num2}");
                Console.WriteLine($"Comparisons for {num1} <= {num2}: {num1 <= num2}");
                Console.WriteLine($"Comparisons for {num1} >= {num2}: {num1 >= num2}");
            }
            else
            {
                Console.WriteLine($"comparision not possible on your input, {userInput1} and {userInput2}");
            }
        }
    }
}
