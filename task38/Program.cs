/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
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

double[] InitArray(int minimal, int maximal, int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        {
            arr[i] = r.Next(minimal, maximal) + Math.Round(r.NextDouble(),2);
        }
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}

void MinMaxArray(double[] array)
{
    int i = 0;
    double min = array[i];
    double max = array[i];
    double difference;


    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    difference = max - min;
    Console.WriteLine($"Минимальное число в массиве - {min}");
    Console.WriteLine($"Максимальное число в массиве - {max}");
    Console.WriteLine($"Разница между минимальным и максимальным числом составляет {difference}");
}

int input = GetNumber("Введите размер массива");
double[] arr = InitArray(0, 10, input);
PrintArray(arr);
Console.WriteLine();
MinMaxArray(arr);

