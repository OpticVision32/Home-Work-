Console.Write("Введите первое число: ");
string numstrA = Console.ReadLine() ?? "";
int numA = Convert.ToInt32(numstrA);

if (numA % 2 == 0) Console.Write("Число четное");
else Console.Write("Число нечетное");

