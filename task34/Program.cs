/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Random r = new Random();
int GetNumber(string msg)
{
    int result;
    Console.WriteLine(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else Console.WriteLine("Ввели не число. Введите число больше нуля");
    }
    return result;
}

int[] InitArray(int min, int max, int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}

void countEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Колличество четных чисел в массиве - {count}");
}

int input = GetNumber("Введите размер массива");
int[] arr = InitArray(100, 999, input);
PrintArray(arr);
System.Console.WriteLine();
countEven(arr);