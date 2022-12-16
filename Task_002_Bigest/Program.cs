// Task #2 What number is bigger

Console.Clear();

Console.WriteLine("Введите первое число: ");
int num_A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num_B = int.Parse(Console.ReadLine()!);

if (num_A > num_B)
{
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
else
{
    Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
}


