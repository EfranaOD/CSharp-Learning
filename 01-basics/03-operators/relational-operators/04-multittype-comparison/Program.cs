using System;

namespace _04_multittype_comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multi-Type Relational Comparison

            Console.Write("Enter anything: ");
            string userInputOne = Console.ReadLine();
            Console.Write("Enter anything: ");
            string userInputTwo = Console.ReadLine();

            bool isInt1 = int.TryParse(userInputOne, out int num1);
            bool isInt2 = int.TryParse(userInputTwo, out int num2);

            bool isDoub1 = double.TryParse(userInputOne, out double double1);
            bool isDoub2 = double.TryParse(userInputTwo, out double double2);

            string type1 = isInt1 ? "int" : isDoub1 ? "double" : "string";
            string type2 = isInt2 ? "int" : isDoub2 ? "double" : "string";


            if (type1 == "int" && type2 == "int")
            {
                Console.WriteLine($"Integer Comparision: {num1} == {num2} -> {num1 == num2}");
                Console.WriteLine($"Integer Comparision: {num1} != {num2} -> {num1 != num2}");
                Console.WriteLine($"Integer Comparision: {num1} < {num2} -> {num1 < num2}");
                Console.WriteLine($"Integer Comparision: {num1} > {num2} -> {num1 > num2}");
                Console.WriteLine($"Integer Comparision: {num1} <= {num2} -> {num1 <= num2}");
                Console.WriteLine($"Integer Comparision: {num1} >= {num2} -> {num1 >= num2}");
            }
            else if (type1 == "double" && type2 == "double")
            {
                Console.WriteLine($"Double Comparision: {double1} == {double2} -> {double1 == double2}");
                Console.WriteLine($"Double Comparision: {double1} != {double2} -> {double1 != double2}");
                Console.WriteLine($"Double Comparision: {double1} < {double2} -> {double1 < double2}");
                Console.WriteLine($"Double Comparision: {double1} > {double2} -> {double1 > double2}");
                Console.WriteLine($"Double Comparision: {double1} <= {double2} -> {double1 <= double2}");
                Console.WriteLine($"Double Comparision: {double1} >= {double2} -> {double1 >= double2}");
            }
            else if (type1 == "string" && type2 == "string")
            {
                int result = String.Compare(userInputOne, userInputTwo);
                Console.WriteLine($"String Comparision: {userInputOne} == {userInputTwo} -> {result == 0}");
                Console.WriteLine($"String Comparision: {userInputOne} < {userInputTwo} -> {result < 0}");
                Console.WriteLine($"String Comparision: {userInputOne} > {userInputTwo} -> {result > 0}");
                Console.WriteLine($"String Comparision: {userInputOne} <= {userInputTwo} -> {result <= 0}");
                Console.WriteLine($"String Comparision: {userInputOne} >= {userInputTwo} -> {result >= 0}");
                Console.WriteLine($"String Comparision: {userInputOne} != {userInputTwo} -> {result != 0}");
            }
            else if (type1 != type2)
            {
                Console.WriteLine($"Mixed Type Comparision: {userInputOne} == {userInputTwo} -> {userInputOne == userInputTwo}");
                Console.WriteLine($"Mixed Type Comparision: {userInputOne} != {userInputTwo} -> {userInputOne != userInputTwo}");
            }
        }
    }
}
