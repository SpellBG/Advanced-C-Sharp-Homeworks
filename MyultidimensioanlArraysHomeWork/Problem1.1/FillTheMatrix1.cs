using System;

class FillTheMatrix1
{
    static void Main()
    {

        int rows = int.Parse(Console.ReadLine());
        int cols = rows;
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[j, i] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col]);
            }
            Console.WriteLine();
        }


    }
}
