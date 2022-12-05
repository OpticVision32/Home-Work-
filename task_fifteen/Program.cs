/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите цифру от 1 до 7: ");
string input = Console.ReadLine() ?? "";

switch (input)
{
    case "1" :
    Console.WriteLine("Понедельник");
    Console.WriteLine("Будний");
    break;
    case "2" :
    Console.WriteLine("Вторник");
    Console.WriteLine("Будний");
    break;
    case "3" :
    Console.WriteLine("Среда");
    Console.WriteLine("Будний");
    break;
    case "4" :
    Console.WriteLine("Четверг");
    Console.WriteLine("Будний");
    break;
    case "5" :
    Console.WriteLine("Пятница");
    Console.WriteLine("Будний");
    break;
    case "6" :
    Console.WriteLine("Суббота");
    Console.WriteLine("Выходной");
    break;
    case "7" :
    Console.WriteLine("Воскресенье");
    Console.WriteLine("Выходной");
    break;
    

    default:
    Console.WriteLine("Вы ввели неверное число");
    break;
}