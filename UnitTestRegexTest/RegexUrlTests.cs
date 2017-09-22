using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRegexTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestRegexTest
{
    [TestClass]
    public class RegexUrlTests
    {
        [Test]
        public void TrueWithDigit([Values("9Baa!deKL", "9Baa?deKL", "9Baa deKL", "9Baa&deKL")] string value)
        {
            var text = UrlReplacements.ReplaceReservedCharacters(value);
            Assert.AreEqual("9Baa_deKL",text);
        }

    }
}
