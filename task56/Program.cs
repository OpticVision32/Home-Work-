/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int SumMatrix(int[,] matrix)
{
    int sum = 0;
    int minSum = 0;
    int numberString = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            if (i == 0 || sum < minSum)
            {
            minSum = sum;
            numberString = i;
            }
            sum = 0;
        }
    }
    return numberString;
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);
int numberString = SumMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Номер строки с наименьшей суммой: {numberString}");