using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_rotate_three_varvalues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rotate Three Values Clockwise without temp variables
            int a = 1, b = 2, c = 3;

            c = b;
            b = a;
            a = b + c;

            Console.Write(a + " "); Console.Write(b + " "); Console.Write(c);
        }
    }
}
