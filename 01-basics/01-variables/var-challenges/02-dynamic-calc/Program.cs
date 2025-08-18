using System;

namespace dynamic_calculator
{
    internal class Program
    {
        public static void Operations(dynamic input1, dynamic input2)
        {
            dynamic Add()
            {
                return input1 + input2;
            }
            dynamic Diff()
            {
                return input1 - input2;
            }
            dynamic Prod()
            {
                return input1 * input2;
            }
            dynamic Div()
            {
                return input1 / input2;
            }
            var sum = Add();
            var diff = Diff();
            var prod = Prod();
            var div = Div();

            Console.WriteLine($"Sum of {input1} and {input2} is, '{sum}'");
            Console.WriteLine($"Difference of {input1} and {input2} is, '{diff}'");
            Console.WriteLine($"Product of {input1} and {input2} is, '{prod}'");
            Console.WriteLine($"Division of {input1} and {input2} is, '{div}'");
        }
        static void Main(string[] args)
        {
            //Ask the user for 2 values.
            //Store them in dynamic variables(start as strings).
            //Convert them at runtime to the type the user specifies(int, double, etc.).
            //Perform addition, subtraction, multiplication, division — all in one method using var for intermediate steps.
            //Print results in literal - interpolated strings(e.g., $"Sum of {a} and {b} is {result}").

            dynamic userInput1, userInput2;
            Console.Write("Enter any number: ");
            userInput1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            userInput2 = Console.ReadLine();

            if (int.TryParse(userInput1, out int intValue1) && int.TryParse(userInput2, out int intValue2))
            {
                userInput1 = Convert.ToInt32(userInput1);
                userInput2 = Convert.ToInt32(userInput2);
                Operations(userInput1, userInput2);
            }
            else if (double.TryParse(userInput1, out double doubleValue1) && double.TryParse(userInput2, out double doubleValue2))
            {
                userInput1 = Convert.ToDouble(userInput1);
                userInput2 = double.Parse(userInput2);
                Operations(userInput1, userInput2);
            }
            else
            {
                Console.WriteLine("Input is not a number, arithmetic operations not possible");
            }
        }
    }
}
