/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();

int N = ReadInt("Введите число N: ");

for (int i = 1; i <= N; i++)
{
        Console.Write(Math.Pow(i,3)+ ", ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}