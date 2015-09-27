using System;


class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string substring = Console.ReadLine();
        int count = 0;

        for (int i = 0; i <= text.Length - substring.Length; i++)
        {

            if (string.Compare(text.Substring(i, substring.Length), substring, true) == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}