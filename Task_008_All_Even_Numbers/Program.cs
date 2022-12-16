// Task #8 To print all even numerics
Console.Clear();

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
};
if (not)
{
    Console.WriteLine("Нет чётных чисел!");
};
