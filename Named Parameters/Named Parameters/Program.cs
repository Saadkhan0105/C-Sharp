using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nameInput = "John";
            int ageInput = 30;
            string addressInput = "123 Main St";

            PrintDetails(age: ageInput,
                         name: nameInput , 
                         address: addressInput );

            Console.ReadLine();
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name} ");
            Console.WriteLine($"Age: {age} ");
            Console.WriteLine($"Address: {address}");
        }
    }
}
