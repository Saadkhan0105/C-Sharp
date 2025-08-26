using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello My name is Saad!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            //Console.WriteLine(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and Your age is " + ageInput);

            Console.ReadLine();
        }
    }
}
