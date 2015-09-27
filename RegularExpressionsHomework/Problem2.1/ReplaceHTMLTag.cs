using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;



class ReplaceHTMLTag
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        string pattern = @"<a.*href=(.*|\n)>(.*|\n)</a>";
        string replace = @"[URL href=$1]$2[/URL]";
        Regex regex = new Regex(pattern);
        input = regex.Replace(input, replace);
        Console.WriteLine(input);

    }
}