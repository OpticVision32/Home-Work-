/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumber(string msg)
{
    int result;
    Console.WriteLine(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else Console.WriteLine("Ввели не число. Введите число больше нуля");
    }
    return result;
}

int[] InitArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber("Введите число");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int SearchPlusEl(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


int size = GetNumber("Введите размер массива");
int[] array = InitArray(size);
PrintArray(array);
System.Console.WriteLine();
int count = SearchPlusEl(array);
System.Console.WriteLine($"Количество введенных вами положительных чисел равно {count}");

