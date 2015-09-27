using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        string pattern = @"\b[\w_.]+@[._\w]+\.\w+\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}