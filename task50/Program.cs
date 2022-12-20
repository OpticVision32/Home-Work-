/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Random r = new Random();

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else System.Console.WriteLine("not number");
    }
    return result;
}

int[,] FillArray(int valueOne, int valueTwo)
{
    int[,] array = new int[valueOne, valueTwo];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(1, 10);
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
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintValue(int[,] array, int numberA, int numberB)
{
    if (numberA <= array.GetLength(0) - 1 && numberB <= array.GetLength(1) - 1) Console.Write($"Значение элемента {numberA},{numberB} = {array[numberA, numberB]}");
    else System.Console.WriteLine("Такого числа нет");
}

int[,] array = FillArray(GetNumber("Введите размер массива"), GetNumber("Введите размер массива"));
PrintArray(array);
PrintValue(array, GetNumber("Введите строку поиска"), GetNumber("Введите столбец поиска"));