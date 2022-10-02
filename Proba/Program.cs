Console.Write("Введите число : ");
string userInput = Console.ReadLine() ?? "";
int n = int.Parse(userInput);
int k = n;
while (n > 1)
{
    if (n % 2 == 0)
    {
        Console.Write(n + ", ");
    }
    n--;
}