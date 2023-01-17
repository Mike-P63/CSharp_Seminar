/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int size = getUserData($"Введите размер массива ");
int[] numbers = new int[size];

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}

void FindEven(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        even += 1; 
    }
    Console.WriteLine($"Всего {numbers.Length} чисел, {even} из них чётные");
}

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
FindEven(numbers);

