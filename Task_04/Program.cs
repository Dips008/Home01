Console.Write("Введите первое число : ");
string userInputa = Console.ReadLine() ?? "";
int a = int.Parse(userInputa);
Console.Write("Введите второе число : ");
string userInputb = Console.ReadLine() ?? "";
int b = int.Parse(userInputb);
Console.Write("Введите третье число : ");
string userInputc = Console.ReadLine() ?? "";
int c = int.Parse(userInputc);
int max = a;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("max -> " + max);