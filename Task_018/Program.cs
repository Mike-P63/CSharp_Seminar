/* Задача 18 Программа., которая по заданному номеру четверти показывает 
возможный диапазон возможных координат точек X and Y */

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

string getRengeFromQuarter(int quarter)
{
    string result = $"Диапазон значения в {quarter} четверти ";
    switch (quarter)
    {
        case 1:
        {
            result += "x > 0 && y > 0";
            break;
        }
        case 2:
        {
            result += "x < 0 && y > 0";
            break;
        }
        case 3:
        {
            result += "x < 0 && y < 0";
            break;
        }
        case 4:
        {
            result += "x > 0 && y < 0";
            break;
        }
        default:
        {
            result = $"Такой четверти {quarter} нет";
            break;
        }
    }
    return result;
}

int quarter = getUserValue("Введите номер четверти");
string rangeDescription = getRengeFromQuarter(quarter);
Console.WriteLine(rangeDescription);
