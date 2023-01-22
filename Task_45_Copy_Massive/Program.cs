/*
Задача 45: Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/ 

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] FillArrayRandomNumbers(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end +1);
    }
    return array;
}
int[] CopyArray(int[] array)
{
    int[] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ,");
    }
    Console.WriteLine("]");
}

int number = getUserData($"Введите размер массива ");
int[] array = FillArrayRandomNumbers(number, -10,10);
PrintArray(array);
int[] result = CopyArray(array);
PrintArray(result);
