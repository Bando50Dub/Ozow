using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sorting
{
    class Sort
    {
        public string SortAlphabetical(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Input cannot be empty, please provide value";
            }

            var result = RemoveSpecialCharacters(input);
            var test = result.OrderBy(c => c).ToArray();

            return new string(result.OrderBy(c => c).ToArray());
        }
        private static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }
    }
}
