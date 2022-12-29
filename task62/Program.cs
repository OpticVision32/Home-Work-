/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillMatrix(int rows, int columns)
{
    int result = 0;
    int[,] matrix = new int[rows, columns];

    for (int x = 0; (x <= rows / 2); x++)
    {
        for (int i = x; i < rows - x; i++)
            matrix[x, i] = ++result;

        for (int i = x + 1; i < rows - x; i++)
            matrix[i, rows - 1 - x] = ++result;

        for (int i = rows - 2 - x; i >= 0 + x; i--)
            matrix[rows - 1 - x, i] = ++result;

        for (int i = rows - 2 - x; i > 0 + x; i--)
            matrix[i, x] = ++result;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


PrintMatrix(FillMatrix(5, 5));




