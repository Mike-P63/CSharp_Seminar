/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int[,] Add2DArray(int colLength, int rowLength, int start, int end)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ;  ");
    }
    Console.WriteLine();
}

void Average(int[,] array)
{
    Console.WriteLine($"Среднее арифметическое каждого столбца -> ");
    Console.WriteLine();
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double result = 0.0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[j, i];
        }
        average[i] = result / array.GetLength(1);
    }
    PrintArray(average);
}

int colLength = getDataFromUser("Введите количество строк");
int rowLength = getDataFromUser("Введите количество столбцов");
int[,] array = Add2DArray(colLength, rowLength, 1, 10);
print2DArray(array);
Console.WriteLine();
Average(array);
Console.WriteLine();




