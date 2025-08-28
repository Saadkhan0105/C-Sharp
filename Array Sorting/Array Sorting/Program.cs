using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10
            };

            string test = "";
            test.Replace(" ", "");

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
