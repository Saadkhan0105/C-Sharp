using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Password_Checker
{
    internal class Program
    {
        /*
         * Ask user to enter a password and store
         * Ask user to re-enter password and store
         * Check if they are both containing something
            * If so check if they are the same
                * If so print "Your password has been set"
                * If not print "Your passwords do not match"
         * If they are empty, Print "Pleae enter a password"
        */
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Console.Write("Re-enter your password: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length > 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Your password is matched");
                        }
                        else
                        {
                            Console.WriteLine("Your passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your password must be at least 6 characters long");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation: ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password");
            }
            Console.ReadLine();
        }
    }
}
