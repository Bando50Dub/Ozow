using SortEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Text To Sort: ");
            string text = Console.ReadLine();

            Sort sortter = new Sort();
            var sortedString = sortter.SortText(text);
            Console.WriteLine(sortedString);
            Console.WriteLine("Press any key to continue..");
            Console.Read();
        }
    }
}
