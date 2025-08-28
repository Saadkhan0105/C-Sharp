using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Saad";
            int age = 29;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age);

            Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);

            Console.ReadLine();
        }
    }
}
