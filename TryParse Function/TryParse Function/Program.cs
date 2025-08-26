using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            string numInput = Console.ReadLine();
            int num = 0;

            int.TryParse(numInput, out num);

            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
