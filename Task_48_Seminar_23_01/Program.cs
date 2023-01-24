﻿/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
Console.Clear();
int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
int[,] get2DIntArray(int colLength, int rowLength, int start, int end)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void print2DArray(int[,] array)
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
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
}

int n = getDataFromUser("Введите количество строк");
int m = getDataFromUser("Введите количество столбцов");
Console.WriteLine();
int[,] array = get2DIntArray(n,m,100,100);
print2DArray(array);
