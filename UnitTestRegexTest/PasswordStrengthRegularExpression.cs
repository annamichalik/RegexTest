using NUnit.Framework;
using System.Text.RegularExpressions;

[TestFixture]
public class PasswordStrengthRegularExpression
{
	private static string PasswordRedularExp = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
	private static string PasswordWithExcludedWordsExp = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^*?])(?i)(?!.*password|.*1234|.*qwerty|.* ).{10,}$";


	[Test]
	public void WithForbiddenWord()
	{
		Regex regex = new Regex(PasswordWithExcludedWordsExp);
		bool match = regex.IsMatch("22PaSSword1!");
		Assert.IsFalse(match);
	}
	[Test]
	public void LessThan8Characters()
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch("tBa!ad7");
		Assert.IsFalse(match);
	}

	[Test]
	public void MissedDigit()
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch("tBa!adeKL");
		Assert.IsFalse(match);
	}
	[Test]
	public void MissedSpecialCharacter()
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch("tBa7adeKL");
		Assert.IsFalse(match);
	}

	[Test]
	public void TrueWithSpecialCharacter([Values("tBa7a!deKL", "?Ba7a!deKL", "tBa7adeKL{")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsTrue(match);
	}

	[Test]
	public void TrueWithDigit([Values("9Baa!deKL", "?Ba7a!deKL", "tBa%adeKL5")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsTrue(match);
	}



	[Test]
	public void WithoutDigit([Values("nBaa!deKL", "?Bana!deKL", "tBa%adeKLn")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsFalse(match);
	}
	[Test]
	public void TrueWithCapitalLetter([Values("Baa!de3m", "?xa7a!deL", "ta%a4eKsl")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsTrue(match);
	}

	[Test]
	public void WithoutCapitalLetter([Values("baa!de3m", "?xa7a!del", "ta%a4ehsl")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsFalse(match);
	}

	[Test]
	public void TrueWithLowerCase([Values("a9BA!d<>KL", "?B'7-!KLx", "B%KL5#$%^mUYT")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsTrue(match);
	}

	[Test]
	public void WithoutLowerCase([Values("19BA!U<>KL", "?B'7-!KL5", "B%KL5#$%^0UYT")] string pass)
	{
		Regex regex = new Regex(PasswordRedularExp);
		bool match = regex.IsMatch(pass);
		Assert.IsFalse(match);
	}
}

