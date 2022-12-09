/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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
            Console.WriteLine("Введено некорректное число");
        }
    }
    return result;
}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
int result = numberA;
for (int i = 1; i < numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine(result);