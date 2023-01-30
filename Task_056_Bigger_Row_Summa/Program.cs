/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2DIntArray(int start, int end, int m = 4, int n = 4)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
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
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void StringSum(int[,] array)
{
    Console.WriteLine();
    double[] Sum = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double result = 0.0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
        Sum[i] = result;
    }
    PrintArray(Sum);
    Console.WriteLine();       
    Console.Write($"Минимальная сумма в строке -> {Sum.Min()}");
    Console.WriteLine();
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine(); 
    Console.Write($"Индекс строки с минимальной суммой -> {minSumRow}");
    Console.WriteLine();  
}

void PrintArray(double[] array)
{
    Console.WriteLine($"Среднее арифметическое каждой строки -> ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ;  ");
    }
    Console.WriteLine();
}

Console.WriteLine();
int[,] array = get2DIntArray(1, 10);
print2DArray(array);
Console.WriteLine();
StringSum(array);
Console.WriteLine();
