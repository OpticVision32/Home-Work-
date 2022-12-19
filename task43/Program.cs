/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

int b1 = GetNumber("Введите число");
int k1 = GetNumber("Введите число");
int b2 = GetNumber("Введите число");
int k2 = GetNumber("Введите число");

double x = (double)(b1 - b2) / (k1 - k2) * -1;
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых имеет координаты: {x}; {y}");