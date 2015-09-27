using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{

    static void Main()
    {
        string inputText = Console.ReadLine();
        foreach (var symbol in inputText)
        {
            Console.Write(String.Format(@"\u{0:x4}", (ushort)symbol));
        }
    }
}