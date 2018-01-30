using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TLS
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = File.ReadAllText("Sample.txt");

            var regexPat = new Regex("[tT][rR][aA]");

            MatchCollection matches = regexPat.Matches(txt);

            Console.WriteLine(matches.Count);
            Console.ReadLine();
        }
    }
}
