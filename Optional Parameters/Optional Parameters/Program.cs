using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5); // Both parameters provided
            Console.WriteLine(result);

            PrintName();

            Console.ReadLine();
        }
        static void PrintName(string name = "Saad")
        {
            Console.WriteLine($"My name is {name}");
        }
        static int Add(int a, int b = default)
        {
            return a + b;
        }
    }
}
