namespace UnitTestRegexTest
{
	using NUnit.Framework;
	using System.Text.RegularExpressions;

	[TestFixture]
	public class TestCodeRegularExpression
	{
		private static string ValidCode = "^(([0-9]{3})|([0-9]{5})|([0-9]{5}-[0-9]{5})|([0-9]{3}-[0-9]{3}))$";


		[Test]
		public void Bad5_3code_WithDash()
		{
			Regex regex = new Regex(ValidCode);
			bool match = regex.IsMatch("12340-123");
			Assert.IsFalse(match);
		}

		[Test]
		public void Bad4()
		{
			Regex regex = new Regex(ValidCode);
			bool match = regex.IsMatch("1234");
			Assert.IsFalse(match);
		}
		[Test]
		public void Ok5_5codeWithDash()
		{
			Regex regex = new Regex(ValidCode);
			bool match = regex.IsMatch("12340-12345");
			Assert.IsTrue(match);
		}
		[Test]
		public void Ok3_3code_WithDash()
		{
			Regex regex = new Regex(ValidCode);
			bool match = regex.IsMatch("340-123");
			Assert.IsTrue(match);
		}

		[Test]
		public void Ok5code()
		{
			Regex regex = new Regex(ValidCode);
			bool match = regex.IsMatch("123");
			Assert.IsTrue(match);
		}
		[Test]
		public void Ok3code()
		{
			Regex regex = new Regex(ValidCode);
			bool match = regex.IsMatch("340-123");
			Assert.IsTrue(match);
		}
	}
}
