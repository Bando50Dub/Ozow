using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort mySort = new Sort();
            var input = Console.ReadLine();

            var sortedString = mySort.SortAlphabetical(input.ToLower());
            Console.WriteLine(sortedString);
            Console.Read();
        }
    }
}
