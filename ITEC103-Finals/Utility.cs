using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC103_Finals
{
    public static class Utility
    {
        public static string RemoveFirstLetterOfAString(string text)
        {
            return text.Substring(1, text.Length-1);
        }
    }
}
