/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
Random r = new Random();

int GetNumber(string msg)
{
    int result = 0;
    while(true)
    {
        System.Console.WriteLine(msg);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else System.Console.WriteLine("Not number");    
    }
    return result;
}

int[,] FillAray(int A, int B)
{
    int[,] array = new int[A,B];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = r.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int inputA = GetNumber("Введите число больше нуля");
int inputB = GetNumber("Введите число больше нуля");

int[,] array = FillAray(inputA, inputB);
PrintArray(array);
