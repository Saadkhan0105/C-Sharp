using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            { 
                0, 1, 2, 3, 4, 5 
            };

            int x = 0;

            int[] sortedNumbers = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            foreach (var num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }

            /*
            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            */

            Console.ReadLine();
        }
    }
}
