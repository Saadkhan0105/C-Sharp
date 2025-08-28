using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Equals_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            string compare = "Hello World";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is: " + name);
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            if (message.Equals(newCompare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();
        }
    }
}
