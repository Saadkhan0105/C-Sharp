using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Odd_Even_Checker
{
    internal class Program
    {
        /*
         * Create and initialise two ints.
         * Make a variable to work out the remainder.
         * Output remainder to the screen.
         * Change the first int variable to another number.
             * and recalculate the remainder.
             * output new remainder to the screen.
        */
        static void Main(string[] args)
        {

            int firstNumber = 10;
            int secondNumber = 3;
            int remainder = firstNumber % secondNumber;

            Console.WriteLine(remainder);

            // Change the first int variable to another number
            firstNumber = 15;
            remainder = firstNumber % secondNumber;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
