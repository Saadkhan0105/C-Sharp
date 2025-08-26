using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Storig_User_Data
{
    internal class Program
    {

        /*
         * Define a variable to hold your name.
         * Define a variable to hold your age.
         * Define a variable to hold your phone number.
         * Print variables line-by-line to the screen.
         * Extra: define a variable using var keyword.
        */
        static void Main(string[] args)
        {
            var name = "Saad";
            var age = 29;
            var number = "0123456789";

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(number);


            Console.ReadLine();
        }
    }
}
