using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Saad";
            int age = 29;

            Console.WriteLine("Your name is " + name + " your age is " + age);
            Console.WriteLine($"Your name is {name} and your age is {age}");


            Console.ReadLine();

        }
    }
}
