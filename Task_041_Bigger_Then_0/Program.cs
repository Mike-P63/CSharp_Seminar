/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int getUserData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ArrayLen = getUserData("Введите количество элементов массива \t ");

void FillArray()
{
    int[] Array = new int[ArrayLen];
    int sum = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        Array[i] = int.Parse(Console.ReadLine());
    }
    Console.Write("[ ");

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine(" ]");
    
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
        sum = sum + 1;
        }
    }
    Console.Write($"Чисел, значение которых больше чем 0: -> {sum}");
}
FillArray();

 