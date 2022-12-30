/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Recurse(int m, int n)
{


    if (m < n) return n += Recurse(m, n - 1);
    if (n < m) return m += Recurse(m - 1, n);
    else return m;

}
System.Console.WriteLine(Recurse(15, 1));