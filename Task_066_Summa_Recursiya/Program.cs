﻿/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getSumOfDig(int A, int B)
{
    if (A == 0)
    {
        return (B * (B + 1)) / 2;
    }
    if (B == 0)
    {
        return(A * (A + 1)) / 2;
    }
    if (A == B) 
    {
        return A;
    }
    if (A < B) 
    {
        return B + getSumOfDig(A, B - 1);
    }
    return B + getSumOfDig(A, B + 1);
}

int A = getFromUserData("Введите число А");
int B = getFromUserData("Введите число B");
int result = getSumOfDig(A, B);
Console.WriteLine(result);
