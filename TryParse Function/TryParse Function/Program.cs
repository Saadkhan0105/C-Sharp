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
            Console.WriteLine("Enter a number");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);

            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
