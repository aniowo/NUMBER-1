using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER_1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the string: ");
                string SentenceString = Console.ReadLine();

                var list = SentenceString.ToLower().GroupBy(s => s).ToList();

                foreach (var c in list)
                {
                    Console.WriteLine("Character " + c.Key + ":" + c.Count() + " times");
                }

            if (string.IsNullOrWhiteSpace(SentenceString))
            {
                Console.WriteLine("ERROR IN INPUT");
            }
            Console.ReadKey();
            }
    }
}
