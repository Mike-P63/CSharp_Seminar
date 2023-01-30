/*
Задача 67: Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/ 

Console.Clear();

int getFromUserData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(msg);
    Console.ResetColor();
    int message  = int.Parse(Console.ReadLine()!);
    return message;
}

int printSum(int number)
{
    if(number == 0)
    {
        return 0;
    }
    return number % 10 + printSum(number / 10);
}

int num = getFromUserData("Введите число");
int result = printSum(num);
Console.WriteLine(result);
