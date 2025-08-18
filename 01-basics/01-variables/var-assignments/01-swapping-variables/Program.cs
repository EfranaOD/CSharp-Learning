using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_swapping_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Swapping Without a Temp Variable
            int a = 10, b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
