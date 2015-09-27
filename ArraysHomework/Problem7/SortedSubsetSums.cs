using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();
        Console.Clear();
        List<List<int>> allSubsets = new List<List<int>>();

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
            allSubsets.Add(currCombo);
        }

        if (allSubsets.Count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            allSubsets.ForEach(list => list.Sort());   
            allSubsets = allSubsets.OrderBy(a => a.Count).ThenBy(b => b.First()).ToList();  
            allSubsets.ForEach(list => Console.WriteLine("{0} = {1}", string.Join(" + ", list), sum));  
        }
    }
}