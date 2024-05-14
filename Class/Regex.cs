using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnalisadorLexico.Model
{
    static class MainRegex
    {
        private const string captureComment = @"\/\/.*|\(\*(?:.|\s)*\*\)";
        private const string captureNumbers = @"(?<!\w)(?:-?\d+(?:\.\d+)?)(?!\w)";
        private const string captureLiteral = @"'(?:[^']|'')*'";
        private const string captureWords = @"\w+";
        private const string captureCharacters = @"(?::=|>=|<=|<>|>|<|=|\+|\-|\*|\/|[:;,.()\[\]{}])";
        private static readonly string capture = $"{captureComment}|{captureNumbers}|{captureLiteral}|{captureWords}|{captureCharacters}";


        // Aqui separo os elementos do texto (matches).
        // Sendo assim, o que é um comentario, numero, literal, um palavra ou um caracter especial
        public static List<String> ReturnListOfSplitString(string text)
        {
            Regex regex = new Regex(capture);
            MatchCollection matches = regex.Matches(text);

            List<String> result = new List<String>();

            foreach (Match item in matches)
                result.Add(item.Value);

            result.RemoveAll(value => value.StartsWith("//") || value.StartsWith("(*"));
            return result;
        }

        public static bool IsNumber(string value)
        {
            Regex regex = new Regex(captureNumbers);
            if(regex.IsMatch(value))
                return true;
            return false;
        }

        public static bool IsLiteral(string value)
        {
            Regex regex = new Regex(captureLiteral);
            if (regex.IsMatch(value))
                return true;
            return false;
        }

        public static bool IsCharacters(string value)
        {
            Regex regex = new Regex(captureCharacters);
            if (regex.IsMatch(value))
                return true;
            return false;
        }

    }
}
