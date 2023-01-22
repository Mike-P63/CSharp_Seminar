﻿/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/ 

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

string Fionachi(int number)
{
    string result = string.Empty;
    int n1 = 0;
    int n2 = 1;
    result = $"{n1}{n2}";
    for (int i = 2; i < number; i++)
    {
        int n = n1 + n2;
        result = result + n;
        n1 = n2;
        n2 = n;
    }
    return result;
}
int number = getUserData("n");
string result = Fionachi(number);
Console.WriteLine(result);
