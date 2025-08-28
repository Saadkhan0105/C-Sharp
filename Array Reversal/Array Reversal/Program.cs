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
            int[] num = new int[]
            { 
                0, 1, 2, 3, 4, 5 
            };

            Array.Reverse(num);

            foreach (var item in num)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
