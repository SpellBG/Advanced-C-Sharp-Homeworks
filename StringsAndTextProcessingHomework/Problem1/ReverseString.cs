using System;
using System.Linq;


class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string inputReversed = string.Join("", input.Reverse());
        Console.WriteLine(inputReversed);
    }
}