using System;
using System.Text.RegularExpressions;

namespace ConsoleRegexTest
{
	public class RegularExpressionTest
	{

		public static void ExtractIPAddress()
		{
			var input = @"weee='20.02.024';var wan_ip='92.75.120.206';if (parent.location.href != window.location.href)";
			IpAddree(input);
			Console.WriteLine("IP address extraction");

		}
		/// <summary>
		/// : \b allows you to perform a “whole words only”
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string InsideSquareBrackets(string value)
		{
			Regex brackets = new Regex(@"\[\[(.*?)\]\]");
			Console.WriteLine(value);
			MatchCollection result = brackets.Matches(value);
			Match match = brackets.Match(value);
			Console.WriteLine(match.Success);
			Console.WriteLine($"count groups {match.Groups.Count}");
			Console.WriteLine($" groups 1 {match.Groups[0]}");
			Console.WriteLine($" groups 2 {match.Groups[1]}");
			Console.WriteLine(result.Count);
			return result.Count > 0 ? result[0].Value : string.Empty;
		}

		public static void ExtractComputerType()
		{
			Console.WriteLine("Computer type extraction");
			Console.WriteLine(InsideSquareBrackets("[[aa]]\\C\\DC"));
			Console.WriteLine(InsideSquareBrackets("[[one]]aaa[[WTH]]"));

		}
		public static void IpAddree(string value)
		{
			Console.WriteLine($"for value :  {value}");
			Regex ip = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
			MatchCollection result = ip.Matches(value);
			Console.WriteLine(result.Count);
			Console.WriteLine(result[0]);

		}
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
