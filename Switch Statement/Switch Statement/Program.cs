using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            /* if (day == 1)
                            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
            } */

            switch (day)
            { 
                    case 1:
                    Console.WriteLine("Monday");
                    break;
                    case 2:
                    Console.WriteLine("Tuesday");
                    break;
                    case 3:
                    Console.WriteLine("Wednesday");
                    break;
                    case 4:
                    Console.WriteLine("Thursday");
                    break;
                    case 5:
                    Console.WriteLine("Friday");
                    break;
                    case 6:
                    Console.WriteLine("Saturday");
                    break;
                    case 7:
                    Console.WriteLine("Sunday");
                    break;
                    default:
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                    break;

            }

            Console.ReadLine();
        }
    }
}
