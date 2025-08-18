using System;

namespace typecaste_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this contains only my personal learning on type conversions, casting, boxing/unboxing, and parsing.

            //Implicit casting
            //int n = 100;
            //long longNum = n;
            //Console.WriteLine($"{n}\n{longNum}");

            //Explicit casting
            //double num = 100.35429876549;
            //float bigNum = (float)num;
            //Console.WriteLine(num + "\n" + bigNum); //float lost precision, prints "100.3543"

            //Boxing
            //object obj = n;
            //Console.WriteLine(obj);

            //Unboxing
            //int numb = (int)n;
            //Console.WriteLine(numb);

            //Conversion
            //Convert():
            //n = Convert.ToInt32("123");
            //string input = Convert.ToString("55");
            //Console.WriteLine(n);
            //Parse():
            //int n2 = int.Parse(input);
            //Console.WriteLine(n2 + " " + n2.GetType());
            //TryParse():
            //bool success = int.TryParse(input, out n);
            //if (success)
            //{
            //    Console.WriteLine("parsing success." + n2);
            //}

            //Basic type checking
            //is
            //object obj2 = "Dazai";
            //if(obj2 is string)
            //{
            //    Console.WriteLine("it is a string " + obj2);
            //}
            //as
            //string name = obj2 as string;
            //Console.Write(name);



            //1. Practice converting between numeric types
            float num = 101.83226F;
            double longNum = num;
            Console.WriteLine($"Implicit Conversion from {num} to {longNum}");

            double longNum2 = 23.92397934342D;
            float num2 = (float)longNum2;
            Console.WriteLine($"Explicit Conversion from {longNum2} to {num2}");

            //2. Parsing strings into numbers
            string str = "123";
            int num3 = int.Parse(str);
            Console.WriteLine(num3 + ": " + num3.GetType());

            //3. Boxing/unboxing examples
            int num4 = 459;
            object obj = num4; //Boxing

            int num5 = (int)obj;//Unboxing

            //4. Using TryParse to handle user input safely
            string str2 = "150";
            int num6;
            bool result = int.TryParse(str2, out num6);
            if( result )
                Console.WriteLine($"parsing is success, from {str2} which is a {str2.GetType()} to {num6} which is now a {num6.GetType()}.");
        }
    }
}
