using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Array_of_Multiples
{
    internal class Program
    {
        /*
         * Define and initialise two integers (num, length).
         * (7, 5) -> [7, 14, 21, 28, 35]
         * Create int array with size of length.
         * loop through and insert the (loop counter x num) into the array.
         * print the final array.
         */
        static void Main(string[] args)
        {
            int num = 10;
            int length = 10;
            int[] result = new int [length];
            int counter = 0;


            for (int i = 1; i <= result.Length; i++, counter++ )
            {
                result[counter] = num * i;
            }

            // Alternative solution
            //for (int i = 1; i <= length; i++)
            //{
            //    result[i] = num * (i + 1);
            //}

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }


            Console.ReadLine();
        }
    }
}
