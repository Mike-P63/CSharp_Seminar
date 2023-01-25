/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] matrix = new int[5, 5];

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void PrintArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillArrayRandomNumbers(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
int rows = getUserData("Введите индекс строки для проверки нахождения числа в массиве ");
int columns = getUserData("Введите индекс столбца для проверки нахождения числа в массиве ");
Console.WriteLine();
void FindNumberInArray(int[,] matrix)
{
    if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1)) Console.WriteLine(matrix[rows, columns]);
    else Console.WriteLine($"{rows} , {columns} -> такого числа в массиве нет");
    Console.WriteLine();
}
FindNumberInArray(matrix);

