Console.Write("Введите число а: ");
string userInputa = Console.ReadLine() ?? "";
int a = int.Parse(userInputa);
Console.Write("Введите число b: ");
string userInputb = Console.ReadLine() ?? "";
int b = int.Parse(userInputb);
if (a > b)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + b);
}