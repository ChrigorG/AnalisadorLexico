using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnalisadorLexico.Model
{
    static class MainRegex
    {
        private const string capture = @"\w+|\W(?<!\s)";

        public static List<String> ReturnListOfSplitString(string text)
        {
            Regex regex = new Regex(capture);
            MatchCollection matches = regex.Matches(text);

            List<String> result = new List<String>();

            foreach (Match item in matches)
                result.Add(item.Value);
            
            return result;
        }
    }
}
