/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.Clear();

int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userData = getDataFromUser("Введите значение границы ряда");

void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write(N + " , ");
    printRange(N - 1);
}
Console.WriteLine();
printRange(userData);
Console.WriteLine();