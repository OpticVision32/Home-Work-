Console.Write("Введите первое число: ");
string numstrA = Console.ReadLine() ?? "";
int numA = Convert.ToInt32(numstrA);
Console.Write("Введите второе число: ");
string numstrB = Console.ReadLine() ?? "";
int numB = Convert.ToInt32(numstrB);
Console.Write("Введите третье число: ");
string numstrC = Console.ReadLine() ?? "";
int numC = Convert.ToInt32(numstrC);

int max = numA;

if (max < numB) max = numB;
if (max < numC) max = numC;

Console.Write(max);

