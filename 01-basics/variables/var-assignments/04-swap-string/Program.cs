using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_swap_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "World", b = "Hello";
            a = b + a;
            b = a.Substring(5);
            a = a.Substring(0, 5);


            Console.WriteLine(a + " " + b);
        }
    }
}
