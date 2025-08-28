using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Checking_a_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int angleCount = 3;
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            /*
            Console.Write("Enter angle 1: ");
            int angle1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle 2: ");
            int angle2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle 3: ");
            int angle3 = Convert.ToInt32(Console.ReadLine());
            int agleSum = angle1 + angle2 + angle3;
            if (agleSum == 180)
            {
                Console.WriteLine("The angles form a triangle.");
            }
            else
            {
                Console.WriteLine("The angles do not form a triangle.");
            }
            */

            Console.ReadLine();
        }
    }
}
