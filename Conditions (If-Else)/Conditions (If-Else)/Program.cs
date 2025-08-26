using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions__If_Else_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);


            Console.WriteLine();
            Console.WriteLine("Your name is: " + name + " and Your age is: " + age);*/


            //== > >= <= != && ||
            /*
            if (age > 18 && age <= 25)
            {
                Console.WriteLine("Your age is between 18 and 25");
            }
            else if (age >= 26 && age <= 35)
            {
                Console.WriteLine("Your age is between 26 and 35");
            }
            else
            {
                Console.WriteLine("You are older than 35");
            }
            */



            /*if (age < 0 || age > 120)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age > 18 && age <= 25)
                {
                    Console.WriteLine("Your age is between 18 and 25");
                }
                else if (age >= 26 && age <= 35)
                {
                    Console.WriteLine("Your age is between 26 and 35");
                }
            }*/



            Console.Write("Enter the first number:");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);


            Console.Write("Enter the second number:");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.Write("Value of  " + numberA + " x " + numberB + ": ") ;
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine("Your answer is wrong.");
            }


            Console.ReadLine();
        }
    }
}
