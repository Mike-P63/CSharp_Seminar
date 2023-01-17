/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

Console.Clear();

/*

int[] generateArray(int length)
{
    int[] result = new int[length];
    for  (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(length);
    }
    return result;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int getUserNumber(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int LookForNumber(int[] array, int number)
{
    int index = -1;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            index = i;
        }
    }
    return index;
}
int Length = getUserNumber("Введите количество элементов массива: ");
int[] Array = generateArray(Length);
printArray(Array);
int Number = getUserNumber("Введите проверочное число: ");
int Index = LookForNumber(Array, Number);
if (Index >=0)
{
    Console.WriteLine($"Искомое число находится на позиции {Index + 1}");
}
    else
    {
        Console.WriteLine("Такого числа нет ");
    }
*/

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();

int[] Fillarray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end +1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int[] Newarray(int[] array)
{
    int newlength = (int)Math.Ceiling(array.Length / 2.0);
    int[] arr = new int[newlength];
    for (int i = 0; i < newlength; i++)
    {
        if (i < newlength - 1 || array.Length%2==0)
        {
            arr[i] = array[i] * array[array.Length- i-1];
        }
        else
        {
              arr[i] = array[i];      
        }
    } 
    return arr;
    
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int number = getUserData("Введите количество элементов массива");
int[] array = Fillarray(number, -10, 10);
printArray(array);
int[] array2 = Newarray(array);
printArray(array2);


