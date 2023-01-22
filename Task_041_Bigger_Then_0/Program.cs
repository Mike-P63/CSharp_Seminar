/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int ArrayLen = getUserData("Введите количество чисел\t ");

void FillArray()
{
    int[] Array = new int[ArrayLen];
    int sum = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Введите число под номером {i + 1}:\t");
        Console.ResetColor();
        Array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.Write("[ ");

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + ", ");
    }
    Console.WriteLine(" ]");

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine();
    Console.Write($"Чисел, значение которых больше чем 0: -> {sum}");
    Console.ResetColor();
}
FillArray();

