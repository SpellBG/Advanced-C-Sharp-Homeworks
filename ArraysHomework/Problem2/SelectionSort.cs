using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ')
                .Select(int.Parse).ToArray();

            SelectionSort(arr);
            Console.WriteLine(string.Join(", ", arr));
        } 

        static void SelectionSort(int[] array)
        {
            int min;
            int minPosition;

            for (int i = 0; i < array.Length; i++)
            {
                min = int.MaxValue;
                minPosition = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minPosition = j;
                    }
                }
                Swap(ref array[i], ref array[minPosition]);
            }
        } 

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        } 
    }
