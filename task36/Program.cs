/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}

void Summ(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        summ += array[i];
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях равна {summ}");
}

int input = GetNumber("Введите размер массива");
int[] arr = InitArray(-9, 10, input);
PrintArray(arr);
System.Console.WriteLine();
Summ(arr);
