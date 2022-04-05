using System.Text.RegularExpressions;

namespace ConsoleRegexTest
{
	public static class UrlReplacements
	{

		public static string ReplaceReservedCharacters(string value)
		{
			var x = Regex.Replace(value.Trim(), @"([^a-zA-Z0-9_-])", "_");
			return x;
		}


		//id="path420" />
		public static string CleanSVGIds(string value)
		{
			var x = Regex.Replace(value.Trim(), "id=\".*?\" ", "_");
			return x;
		}

	}
}
