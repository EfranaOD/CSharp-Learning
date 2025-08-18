using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_reassign_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reassigning variables
            string firstName = "Mohammed";
            string lastName = firstName;

            firstName = "Efrana";

            Console.WriteLine(firstName + " " + lastName);
            //the output will be Efrana Mohammed. lastname will be holding Mohammed assigned from the firstname, and the reassignment of firstname to efrana changes its original values from mohammed to efrana. while printing, firstname is holding its reassigned value and lastname is holding the value it was assigned from firstnames original value.
        }
    }
}
