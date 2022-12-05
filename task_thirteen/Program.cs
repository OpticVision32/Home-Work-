Console.WriteLine("Введите число: ");
int input = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string inputStr = input.ToString();
if (input > 99)
{
    Console.WriteLine($"Третья цифра - {inputStr[2]}" );
}
else 
{
    Console.WriteLine($"Третьей цифры нет");
}
