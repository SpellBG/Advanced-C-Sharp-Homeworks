using System;
using System.Linq;



class MaxSum
{
    static void Main()
    {
        int[] temp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
        int rows = temp[0];
        int cols = temp[1];
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int num = int.Parse(Console.ReadLine());
                matrix[row, col] = num;

            }
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                    matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] +
                    matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }

        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
        Console.WriteLine("The best platform is:");
        Console.WriteLine(" {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1],
            matrix[bestRow, bestCol + 2]);
        Console.WriteLine(" {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1],
            matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine(" {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1],
            matrix[bestRow + 2, bestCol + 2]);

    }
}
