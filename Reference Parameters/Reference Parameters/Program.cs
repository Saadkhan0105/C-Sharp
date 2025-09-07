﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 10;
            string name = "Hello";
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);
            */

            string name = "John";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }

            Console.ReadLine();
        }
        
        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
                return false;
        }
        static void Assign(ref int  num, ref string name)
        {
            name = "Saad";
            num =  20;
        }
    }
}
