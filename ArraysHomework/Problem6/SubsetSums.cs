using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
        Console.Clear();
        bool match = false;

        for (int mask = 1; mask < Math.Pow(2, arr.Length); mask++)
        {
            List<int> currCombo = new List<int>();
            for (int bit = 0; bit < arr.Length; bit++)
            {
                if ((mask >> bit & 1) == 1)
                {
                    currCombo.Add(arr[bit]);
                }
            }

            if (currCombo.Sum() != sum) continue;

            Console.WriteLine("{0} = {1}", string.Join(" + ", currCombo), sum);
            match = true;
        }

        if (!match)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}