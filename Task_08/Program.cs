Console.Write("Введите число : ");
string userInput = Console.ReadLine() ?? "";
int n = int.Parse(userInput);
int count = 1;
int k = n;
while (count < n)
{
    if (k % 2 == 0)
    {
        Console.Write(k + ", ");
    }
    k--;
    count++;
}