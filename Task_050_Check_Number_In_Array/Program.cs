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
int rows = getUserData("Введите индекс строки для проверки нахождения числа в массиве ");
int columns = getUserData("Введите индекс столбца для проверки нахождения числа в массиве ");

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
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}


FillArrayRandomNumbers(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1)) Console.WriteLine(matrix[rows, columns]);
else Console.WriteLine($"{rows} , {columns} -> такого числа в массиве нет");
Console.WriteLine();
