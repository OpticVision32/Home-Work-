/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Random r = new Random();

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        System.Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else System.Console.WriteLine("not number");

    }
    return result;
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = r.Next(1, 9);
        }
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

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int minPositionI = i;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPositionJ = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[minPositionI, minPositionJ])
                {
                    int temp = matrix[minPositionI, minPositionJ];
                    matrix[minPositionI, minPositionJ] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);
SortMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);