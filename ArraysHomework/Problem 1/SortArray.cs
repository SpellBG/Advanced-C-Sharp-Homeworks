using System;
using System.Linq;

class SortArary
{
    static void Main()
    {
        

        int[] num = Console.ReadLine().Trim().Split()
            .Select(int.Parse).ToArray();

        Array.Sort(num);

        Console.WriteLine("{0}", string.Join(" ", num));


    }
}

