using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var keyword - The var keyword is used to declare variables with an implicit type.
            // var keyword can only be used for local variables. Values of variables can be changed later.

            var age = 23;
            Console.WriteLine(age);

            var bigNumber = 12345678901234567890;
            Console.WriteLine(bigNumber);

            // const keyword - The const keyword is used to declare constants, which are variables whose value cannot change after they are initialized.
            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * ( vat / 100D));
            Console.WriteLine(balance * ( vat / 100D));

            Console.WriteLine(vat);

            Console.ReadLine();

        }
    }
}
