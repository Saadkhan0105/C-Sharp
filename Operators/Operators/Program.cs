using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 23;
            Console.WriteLine("Initial Age: " + age);


            // Arithmetic Operators
            age++; // Increment operator
            age += 10; // Another way to increment   
            Console.WriteLine("Age after increment: " + age);

            age--; // Decrement operator
            age -= 5; // Another way to decrement
            Console.WriteLine("Age after decrement: " + age);

            
            age /= 10; // Division operator
            Console.WriteLine("Age after division: " + age);

            string name = "Saad";
            name += " Khan"; // Concatenation operator
            Console.WriteLine("Full Name: " + name);

            char ch = 'a';
            ch += 'b'; 
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i);


            // Comparison Operators
            int firstNum = 10;
            int secondNum = 2;

            Console.WriteLine(firstNum % secondNum);


            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);

            Console.ReadLine();
        }
    }
}
