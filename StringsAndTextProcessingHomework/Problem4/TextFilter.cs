using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextFilter
{
   
 static void Main()
 {
        
    List<string> bannedWords = Console.ReadLine().Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList<string>();
    string text = Console.ReadLine();
    foreach (var word in bannedWords)
    {
        text = text.Replace(word, new string('*', word.Length));
    }
    Console.WriteLine(text);
 }
}