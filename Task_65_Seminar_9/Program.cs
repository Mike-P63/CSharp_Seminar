/*
Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/ 

Console.Clear();

int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result  = int.Parse(Console.ReadLine()!);
    return result;
}

int userNumberStart = getFromUserData("Введите значение границы ряда");
int userNumberFinish = getFromUserData("Введите значение границы ряда");
string range= getStrRange(userNumberStart, userNumberFinish);
int start = Math.Min(userNumberStart, userNumberFinish);
int finish = Math.Max(userNumberStart, userNumberFinish);
Console.WriteLine(range);

string getStrRange(int start, int finish)
{
    if (start == finish)
    {
        return start + "";
    }
    return start +" , " + getStrRange(start + 1, finish);
}