/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/




int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine("Введите число");
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введено некорректное число");
        }
    }
    return result;
}

int inputNumber = GetNumber("Введите число");

for (int i = 1; i <= inputNumber; i++)
{
    Console.Write($"{Math.Pow((i),3)}   ");
}