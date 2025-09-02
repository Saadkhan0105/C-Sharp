using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);
            Console.WriteLine(num);
            //Console.WriteLine(success);

            // int.TryParse()

            List<string> shoppingList = new List<string>
            {
                "Coffee","Milk"
            };

            Console.WriteLine(shoppingList.IndexOf("Milk"));
            //Console.WriteLine(FindInList("Coffee", shoppingList, out int index));
            //Console.WriteLine(index);

            Console.Write("Enter an item to search: ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Found {search} at index {index}");
            }
            else
            {
                Console.WriteLine($"Not Found {search}");
            }
            /*
            int index = -1;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals("milk"))
                {
                    index = i;
                }
            }
            bool found = index > -1 ? true : false;
            Console.WriteLine(found ? "Found" : "Not Found");
            */

            Console.ReadLine();
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;

             

        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static void test(out int num)
        {
            num = 5;
            // return true;
        }
    }
}
