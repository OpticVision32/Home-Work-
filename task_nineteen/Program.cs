/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result < 100000)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число");
        }

    }
    return result;
}
int inputNumber = GetNumber("Введите пятизначное число: ");
string inputNumberString = inputNumber.ToString();

if (inputNumberString[0] == inputNumberString[4] && inputNumberString[1] == inputNumberString[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}





