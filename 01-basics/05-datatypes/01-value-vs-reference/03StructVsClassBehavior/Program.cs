using System;

namespace _03StructVsClassBehavior
{
    internal class Program
    {
        struct Point
        {
            public int X, Y;
        }

        class Coordinates
        {
            public int X, Y;
        }

        static void Main(string[] args)
        {
            //Create a custom struct and a custom class, assign one variable to another for both, and show the difference in behavior.

            var S1 = new Point { X = 10, Y = 20 };
            var S2 = S1;
            S1.X = 50;

            var C1 = new Coordinates { X = 100, Y = 200 };
            var C2 = C1;
            C1.X = 150;

            Console.WriteLine(S1.X + " " + S2.X);
            Console.WriteLine(C1.X + " " + C2.X);
        }
    }
}
