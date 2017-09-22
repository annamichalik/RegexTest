using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleRegexTest
{
    public static class UrlReplacements
    {

        public static string ReplaceReservedCharacters(string value)
        {
            var x = Regex.Replace(value.Trim(), @"([^a-zA-Z0-9_-])", "_");
            return x;
        }
    }
}
