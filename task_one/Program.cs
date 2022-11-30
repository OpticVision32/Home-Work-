Console.Write("Введите первое число: ");
string numstrA = Console.ReadLine() ?? "";
int numA = Convert.ToInt32(numstrA);
Console.Write("Введите второе число: ");
string numstrB = Console.ReadLine() ?? "";
int numB = Convert.ToInt32(numstrB);
int max = numA;
int min = numB;

if (numB > numA) {max = numB; min = numA;}
else {max = numA; min = numB;}

Console.Write($"Число {max} больше, чем число {min}");



