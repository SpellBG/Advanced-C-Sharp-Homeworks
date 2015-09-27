using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();

        string twentyCharacters = text.Length > 20 ? new string(text.Take(20).ToArray()) : text;
        Console.WriteLine(twentyCharacters.PadRight(20, '*'));
    }
}