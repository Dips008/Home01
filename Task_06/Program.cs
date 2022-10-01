Console.Write("Введите число : ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);
Console.Write("Число " + a);
if (a % 2 == 0)
{
    Console.Write(" -> четное");
}
else
{
    Console.Write(" -> не четное");
}