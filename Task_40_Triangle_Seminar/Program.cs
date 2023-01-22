/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника:
каждая сторона треугольника меньше суммы двух других сторон
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

bool IsTriangleExist(int a, int b, int c)
{
    bool isExist = false;
    if(a < b + c && b < c + a && c < b + a)
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserData("Введите длину стороны А");
int b = getUserData("Введите длину стороны B");
int c = getUserData("Введите длину стороны C");
bool isExist = IsTriangleExist(a,b,c);

Console.WriteLine($"Треугольник со сторонами [{a}, {b}, {c}] {((isExist)?"существует":"не существует")}");

/*
string str = (isExist)?"существует":"не существует";


if (isExist)
{
    str = "существует";
}
else
{
    str = "не существует";
}
*/