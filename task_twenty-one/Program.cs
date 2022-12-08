/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }

        else
        {
            Console.WriteLine("Некорректное число");
        }
    }
    return result;
}

int CoordinateXA = GetNumber("Введите координату X");
int CoordinateYA = GetNumber("Введите координату Y");
int CoordinateZA = GetNumber("Введите координату Z");

int CoordinateXB = GetNumber("Введите координату X");
int CoordinateYB = GetNumber("Введите координату Y");
int CoordinateZB = GetNumber("Введите координату Z");

double result = Math.Sqrt(Math.Pow((CoordinateXB - CoordinateXA),2) + Math.Pow((CoordinateYB - CoordinateYA),2) + Math.Pow((CoordinateZB - CoordinateZA),2));

Console.WriteLine(Math.Round((result),2));

