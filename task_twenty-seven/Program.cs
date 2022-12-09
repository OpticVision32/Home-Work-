/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string msg)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(msg);
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

int inputNumber = GetNumber("Введите число: ");
int result = 0;


while (inputNumber > 10)
{
    result = result + inputNumber % 10;
    inputNumber = inputNumber/10;
}
result = result + inputNumber;

Console.WriteLine(result);

