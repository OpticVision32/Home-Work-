/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string Recurse(int n, int b)
{


    if (n > b) return $"{n} " + Recurse(n - 1, b);
    else return "1";

}

System.Console.WriteLine(Recurse(9, 1));


