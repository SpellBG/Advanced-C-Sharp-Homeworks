using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LegoBlocks
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        List<List<int>> firstList = new List<List<int>>();
        List<List<int>> secondList = new List<List<int>>();

        FillList(rows, firstList);
        FillList(rows, secondList);

        MergeLists(firstList, secondList);

        if (!IsRectangle(firstList))
        {
            int count = 0;
            foreach (List<int> list in firstList)
            {
                count += list.Count();
            }
            Console.WriteLine("The total number of cells is: {0}", count);
        }
        else
        {
            foreach (List<int> list in firstList)
            {
                Console.WriteLine(PrintList(list));
            }
        }
    }

    private static void FillList(int n, List<List<int>> list)
    {
        for (int i = 0; i < n; i++)
        {
            list.Add(new List<int>());
            int[] array = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            foreach (var el in array)
            {
                list[i].Add(el);
            }
        }
    } 

    private static void MergeLists(List<List<int>> first, List<List<int>> second)
    {
        for (int i = 0; i < first.Count; i++)
        {
            second[i].Reverse();
            first[i].AddRange(second[i]);
        }
    } 

    private static bool IsRectangle(List<List<int>> input)
    {
        bool isRectangle = false;
        int rowLength = input[0].Count();
        for (int i = 1; i < input.Count; i++)
        {
            if (rowLength == input[i].Count())
            {
                isRectangle = true;
            }
            else
            {
                isRectangle = false;
                break;
            }
        }
        return isRectangle;
    } 

    static string PrintList<T>(List<T> myList)
    {
        StringBuilder strBuilder = new StringBuilder();
        strBuilder.Append("[");
        for (int i = 0; i < myList.Count - 1; i++)
        {
            strBuilder.AppendFormat("{0}, ", myList[i]);
        }
        strBuilder.AppendFormat("{0}]", myList[myList.Count - 1]);

        return strBuilder.ToString();
    } 
}