using ConsoleRegexTest;
using NUnit.Framework;


[TestFixture]
public class RegexUrlTests
{
	[Test]
	public void TrueWithDigit([Values("9Baa!deKL", "9Baa?deKL", "9Baa deKL", "9Baa&deKL")] string value)
	{
		var text = UrlReplacements.ReplaceReservedCharacters(value);
		Assert.AreEqual("9Baa_deKL", text);
	}

	[Test]
	public void CleanSVGIds([Values("id=\"path420\" />", "id=\"pathaa420\" />")] string value)
	{
		var text = UrlReplacements.CleanSVGIds(value);
		Assert.AreEqual("_ />", text);
	}
}
