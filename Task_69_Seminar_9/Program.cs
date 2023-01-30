/* 
Задача 69: Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А в 
целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
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

int getSumOfDig(int numA, int numB)
{
    if (numB == 1)
    {
        return numA;
    }
    return numA * getSumOfDig(numA, numB -1);
}
int numA = getFromUserData("Введите число А");
int numB = getFromUserData("Введите число B");
int result= getSumOfDig(numA, numB);
Console.WriteLine(result);
