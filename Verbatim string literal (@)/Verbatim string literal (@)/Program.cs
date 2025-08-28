using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbatim_string_literal____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // \t - tab \n - new line \\ - backslash

            string speech = "Hello \nMy name is John \tI am a developer";
            Console.WriteLine(speech);

            string path = "C:\\Users\\Admin\\Desktop\\C - sharp";
            Console.WriteLine(path);

            path = @"C:\Users\Admin\Desktop\C - sharp";
            Console.WriteLine(path);

            string name  = @"Hello ""John""";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
