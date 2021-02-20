using System.Linq;
using System.Text.RegularExpressions;

namespace SortEngine
{
    public class Sort
    {
        public string SortText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Please enter the text to sort";
            }

            // Remove special characters & convert to lower
            text = Regex.Replace(text, "[^a-zA-Z0-9_]+", "", RegexOptions.Compiled).ToLower();
            return new string(text.OrderBy(c => c).ToArray());
        }
    }
}
