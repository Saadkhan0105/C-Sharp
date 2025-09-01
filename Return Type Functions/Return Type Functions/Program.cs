using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Type_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"{ReturnName()} - {ReturnAge()}";
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        static int[] CreateRandomArray()
        {
            return new int[3] { 0, 1, 2};
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Saad";
        }
        static int ReturnAge()
        {
            return 29;
        }
        static void PrintIntroduction()
        {
            /*
            string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hello my name is {name} and my age is {age}";
            Console.WriteLine(output);
            */

            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }
    }
}
