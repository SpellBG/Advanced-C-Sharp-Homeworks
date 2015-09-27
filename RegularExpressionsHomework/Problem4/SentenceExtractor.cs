﻿using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = string.Format(@"\w+[\w\s]+\bis\b[\w\s]+[.|!|?]", keyword);
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}