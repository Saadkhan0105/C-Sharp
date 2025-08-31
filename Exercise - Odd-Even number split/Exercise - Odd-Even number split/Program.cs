using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Odd_Even_number_split
{
    internal class Program
    {
        /*
         * Create two lists with integer data type, one for even numbers and one for odd numbers.
         * Loop from 0-20
            * If the number is even, add it to the even list.
            * If the number is odd, add it to the odd list.
         * Print even list
         * Print odd list
        */
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();


            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                    {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing Even numbers: ");
            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Environment.NewLine + "Printing Odd numbers: ");
            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
