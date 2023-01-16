
/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int Chislo(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int number = Chislo("Введите число, состоящее из нескольких цифр: ");
int len = number;

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

SumNumbers(number, len);
