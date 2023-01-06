/* 
Задача № 17. Напишите программу, которая принимает на вход координаты точки (x и y),
причем Х != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.
*/
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int getQuorterNumber(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}

int userX = getUserValue("Введите X");
int userY = getUserValue("Введите Y");
int quarter = getQuorterNumber(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userX},{userY}] находятся в {quarter} четверти");
}
else
{
    Console.WriteLine($"Точка [{userX},{userY}] находятся на оси координат");
}
