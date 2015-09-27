using System;
using System.Collections.Generic;

class PythagoreanNumbers
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberCount];
        for (int i = 0; i < numberCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        List<int> numbersSquared2 = new List<int>();
        foreach (int el in numbers)
        {
            numbersSquared2.Add(el * el);
        }
        int count = 0;
        foreach (int a in numbers)
        {
            foreach (int b in numbers)
            {
                int cSquared = a * a + b * b;
                if (a <= b && numbersSquared2.Contains(cSquared))
                {
                    int c = (int)Math.Sqrt(cSquared);
                    Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }

    }
}