using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> names = new Dictionary<int, string>
            {
                // Key value pairs
                { 1, "Saad" },
                { 2, "Test" },
                { 3, "Test" }
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");

            }

            Console.WriteLine()
                ;
            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                { "Math", "Saad" },
                { "Science", "Test" }
            };

            Console.WriteLine(teachers["Math"]);

            Console.ReadLine(); 
        }
    }
}
