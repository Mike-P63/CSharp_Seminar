Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine()!);
int amount = number.ToString().Length;
int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}