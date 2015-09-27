using System;
using System.Linq;

class StuckNumbers
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        int[] numbers = Console.ReadLine().Trim().Split().
            Select(int.Parse).ToArray();

        int count = 0;
        for (int num1 = 0; num1 < numbers.Length; num1++)
        {
            for (int num2 = 0; num2 < numbers.Length; num2++)
            {
                for (int num3 = 0; num3 < numbers.Length; num3++)
                {
                    for (int num4 = 0; num4 < numbers.Length; num4++)
                    {
                        int a = numbers[num1];
                        int b = numbers[num2];
                        int c = numbers[num3];
                        int d = numbers[num4];
                        if (a != b && a != c & a != d && b != c && b != d && c != d)
                        {
                            string firstPart = "" + a + b;
                            string secondPart = "" + c + d;
                            if (firstPart.Equals(secondPart))
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                count++;
                            }
                        }
                    }
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }

    }
}