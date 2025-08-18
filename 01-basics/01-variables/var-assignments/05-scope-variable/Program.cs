using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_scope_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y, z;
            {
                x = 10;
                y = x + 10;
                x = x + y;
                z = x + y;
                Console.WriteLine($"X: {x}, Y: {y}, Z: {z}"); //x=20(5+10+5), y=15(5+10), z=35(20+15)
            }
            Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");


        }
    }
}
