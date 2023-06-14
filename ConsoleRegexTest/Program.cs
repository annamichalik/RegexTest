using System;

namespace ConsoleRegexTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//var str = "C:\\wewr\\asdasda\\tw.docx";
			//Console.WriteLine("{0} is valid {1}", str, RegularExpressionTest.IsValid(str));
			//str = "C:\\wewr\\asdasda\\tw.1234567";

			//Console.WriteLine("{0} is valid {1}", str, RegularExpressionTest.IsValid(str));
			//str = "raz asdasd trzy" +
			//    "";
			//Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
			//str = "Cwewr asdasd 1234567";
			//Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
			//str = "Cwewr asdasd 1234567 four";
			//Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
			//str = "Cwewr asdasd one four";
			// Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
			//DateTime cityStateLastImport;
			//DateTime.TryParse("n/a", out cityStateLastImport);
			//Console.WriteLine("{0} is a date or null !", cityStateLastImport);
			RegularExpressionTest.ExtractComputerType();
			RegularExpressionTest.ExtractIPAddress();

			Console.ReadKey();
		}
	}
}
