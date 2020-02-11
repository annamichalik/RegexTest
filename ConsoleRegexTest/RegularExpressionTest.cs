using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleRegexTest
{
    public class RegularExpressionTest
    {

        public static void MakeTest()
        {

            Console.WriteLine(SeparateWords("SMBrosO"));
            Console.WriteLine(SeparateWords("TryAgainWithMoreWorkds"));
            Console.WriteLine(SeparateWords("OneTWOThree"));
        }

        // from blog http://adamprescott.net/
        public static string SeparateWords(string value)
        {
            var x = Regex.Replace(value, @"([A-Z][^A-Z])", " $1");
            x = Regex.Replace(x, "([a-z])([A-Z])", "$1 $2");
            x = x.Trim();
            return x;
        }

        /// <summary>
        /// Test string using Regex.IsMatch static method.
        /// </summary>
        public static bool IsValid(string value)
        {
            string matchString =
                @"^.*\\(.){1,2}\.(.){1,6}$";
            return Regex.IsMatch(value, matchString);
        }

        /// <summary>
        /// Is there 3 words  ^(?:\b\w+\b[\s\r\n]*){0,3}$
        /// 
        ///
        /// </summary>
        public static bool Has3Words(string value)
        {
            string matchString =
                @"^(?:\b\w+\b[\s\r\n]*){0,3}$";
            return Regex.IsMatch(value, matchString);
        }
        public static void DoLAzy()
        {

            string msg = "=?windows-1258?B?UkU6IFRyIDogUGxhbiBkZSBjb250aW51aXTpIGQnYWN0aXZpdOkgZGVz?= =?windows-1258?B?IHNlcnZldXJzIFdlYiBHb1ZveWFnZXN=?=";
            var charSetOccurences = new Regex(@"=\?.*?\?[BQ]\?.*?\?=", RegexOptions.IgnoreCase);
            MatchCollection matches = charSetOccurences.Matches(msg);
            foreach (Match match in matches)
            {
                string[] encoding = match.Groups[0].Value.Split(new string[] { "?" }, StringSplitOptions.None);
                string charSet = encoding[1];
                string encodeType = encoding[2];
                string encodedString = encoding[3];
                Console.WriteLine("Charset: " + charSet);
                Console.WriteLine("Encoding type: " + encodeType);
                Console.WriteLine("Encoded String: " + encodedString + "\n");
            }

            charSetOccurences = new Regex(@"=\?.*\?B\?.*\?=", RegexOptions.IgnoreCase);
            var charSetMatches = charSetOccurences.Matches(msg);
            foreach (Match match in charSetMatches)
            {
                Console.WriteLine("greedy {0}", match);
                //charSet = match.Groups[0].Value.Replace("=?", "").Replace("?B?", "").Replace("?b?", "");
            }

        }
    }
}
