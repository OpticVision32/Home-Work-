/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трёхзначное число: ");
int input = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (input > 99 && input < 1000)
{
    int result = (input / 10) % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}

