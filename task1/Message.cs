using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;

namespace homeWorks
{
    internal static class Message
    {
        static Regex _re;
        
        public static void PrintWords(int lettersCount, string text)
        {
            _re = new Regex(@"\b[a-z]{1," + lettersCount + @"}\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            foreach(Match m in _re.Matches(text))
            {
                WriteLine(m.Value);
            }
        }
        public static string RemoveWords(char simbol, string text)
        {
            if (char.IsLetterOrDigit(simbol) || simbol == '_')
                _re = new Regex(@"\b[a-z]+" + simbol + @"\b");
            else _re = new Regex(@"\b[a-z]+" + simbol + @"\B");
            return _re.Replace(text, "");            
            
        }
        public static string FindLongestWord(string text)
        {
            _re = new Regex(@"\w+");
            string word = "";
            int l = 0;
            foreach (Match m in _re.Matches(text))
                if (m.Length > l)
                {
                    l = m.Length;
                    word = m.Value;
                }
            return word;
        }
        public static StringBuilder LongestWords(string text)
        {
            StringBuilder result = new StringBuilder();
            int l = 0;
            _re = new Regex(@"\w+");
            foreach(Match m in _re.Matches(text))
                if(m.Length > l) l = m.Length;
            foreach(Match m in _re.Matches(text))
                if(m.Length == l) result.Append(m.Value + " ");
            return result;
        }
    }
}
