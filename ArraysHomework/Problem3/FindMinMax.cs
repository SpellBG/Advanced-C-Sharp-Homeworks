using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FindMinMax
{
    static void Main(string[] args)
    {
        
        double[] myArray = Console.ReadLine().Trim().Split(' ')
            .Select(double.Parse).ToArray();

        List<int> myIntList = new List<int>();
        List<double> myDoubleList = new List<double>();

        foreach (var item in myArray)
        {
            if (item == (int)item)
            {
                myIntList.Add((int)item);
            }
            else
            {
                myDoubleList.Add(item);
            }
        }

        PrintResult(myDoubleList, myIntList);
    }

    static void PrintResult(List<double> myDoubleList, List<int> myIntList)
    {
        Console.WriteLine();
        Console.WriteLine("{0} -> min: {1}, max: {2}, sum: {3}, average: {4:F2}",
            PrintList(myDoubleList), myDoubleList.Min(), myDoubleList.Max(), myDoubleList.Sum(), myDoubleList.Average());
        Console.WriteLine();
        Console.WriteLine("{0} -> min: {1}, max: {2}, sum: {3}, average: {4:F2}",
            PrintList(myIntList), myIntList.Min(), myIntList.Max(), myIntList.Sum(), myIntList.Average());
        Console.WriteLine();
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