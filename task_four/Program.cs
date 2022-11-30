Console.Write("Введите первое число: ");
string numstrA = Console.ReadLine() ?? "";
int numA = Convert.ToInt32(numstrA);

for (int i = 2; i <= numA; i=i+2)
{
    Console.Write(i+ " ");
}