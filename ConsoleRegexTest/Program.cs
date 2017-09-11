using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "C:\\wewr\\asdasda\\tw.docx";
            Console.WriteLine("{0} is valid {1}", str, RegularExpressionTest.IsValid(str));
            str = "C:\\wewr\\asdasda\\tw.1234567";
            Console.WriteLine("{0} is valid {1}", str, RegularExpressionTest.IsValid(str));
            RegularExpressionTest.MakeTest();
            RegularExpressionTest.DoLAzy();
            Console.ReadKey();
        }
    }
}
