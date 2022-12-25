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
    double result = Math.Sqrt(Math.Pow((userAx - userBx)) + Math.Pow((userAy - userBy)));
    return result;
    Console.WriteLine("Расстояние равно "getDistanceFromCoordinates);
}
int userAx = getCoordinatesLength("Введите X");
int userAy = getCoordinatesLength("Введите X");

int userBx = getCoordinatesLength("Введите X");
int userBy = getCoordinatesLength("Введите X");