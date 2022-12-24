Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
if (x < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (x >= 1000)
    {
        x = x / 10;
    }

    if (x < 1000)
    {
        int three = x % 100;
        int a = three % 10;
        Console.Write(a);
    }
}