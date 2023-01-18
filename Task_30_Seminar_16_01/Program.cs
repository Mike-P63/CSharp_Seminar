/* Task 31 
Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка -9 до 9. Найдите сумму отрицательных и положительных элементов
массива. 
*/


Console.Clear();
/*
int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for  (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
// flag - 1 - положительное flag - -1 тогда отрицательное
int getSumOfPositiveOrNegative(int[] array, int flag = 1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * flag > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = generateArray(12,-9,9);
printArray(array);
int sumOfPositive = getSumOfPositiveOrNegative(array,1);
int sumOfNegative = getSumOfPositiveOrNegative(array,-1);
Console.WriteLine($"Сумма положительных = {sumOfPositive}");
Console.WriteLine($"Сумма отрицательных = {sumOfNegative}");
*/

/*
Задача 32: Напишите программу замены элементов массива: положительные 
элементы замените на соответствующие отрицательные и наоборот.
[-4, -8, 8, 2] => [4, 8, -8, -2]
*/


int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for  (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}
int[] invertArray(int[] arrayToInvert)
{
    for (int i = 0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = - arrayToInvert[i];
    }
    return arrayToInvert;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int length = getIntFromUser("Введите длину массива");
int[] Array = generateArray(length, -100,100);
printArray(Array);
int[] invertedArray = invertArray(Array);
printArray(invertedArray);
