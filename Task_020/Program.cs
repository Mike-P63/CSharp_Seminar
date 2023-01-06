/* 21 Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double getDistanceFromCoordinates(int userAx, int userAy, int userBx, int userBy)
{
    double result = Math.Sqrt(Math.Pow((userAx - userBx), 2) + Math.Pow((userAy - userBy), 2));
    return result;
    
}
int userAx = getUserValue("Введите X");
int userAy = getUserValue("Введите Y");

int userBx = getUserValue("Введите X");
int userBy = getUserValue("Введите Y");

double distance = getDistanceFromCoordinates(userAx, userAy, userBx, userBy);
Console.WriteLine($"Расстояние равно {distance}");