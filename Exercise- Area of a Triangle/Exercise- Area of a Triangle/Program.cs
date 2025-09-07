using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__Area_of_a_Triangle
{
    /*
     * Ask user for width and height and store them.
     * Create function to calculate area.
     * FUnction should calculate the area using: (width * height) / 2
     * Call in main and print out the area of the tirangle.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int width = ReadInt("Enter the width of the triangle: ");
            int height = ReadInt("Enter the height of the triangle: ");

            Console.WriteLine($"The area of the triangle is: {CalculateArea(width, height)}");

            Console.ReadLine();
        }
        static int CalculateArea(int width, int height)
        {
            return (width * height) / 2;
        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
