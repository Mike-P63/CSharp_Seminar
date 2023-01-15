/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sumNumbersIndex = 0;

void Sum(int sumNumbersIndex)
{
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sumNumbersIndex += numbers[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях = {sumNumbersIndex}");
}

Sum(sumNumbersIndex);


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
