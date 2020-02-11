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
            str = "raz asdasd trzy" +
                "";
            Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
            str = "Cwewr asdasd 1234567";
            Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
            str = "Cwewr asdasd 1234567 four";
            Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
            str = "Cwewr asdasd one four";
            Console.WriteLine("{0} is valid = {1}", str, RegularExpressionTest.Has3Words(str));
            RegularExpressionTest.MakeTest();
            RegularExpressionTest.DoLAzy();
            Console.ReadKey();
        }
    }
}
