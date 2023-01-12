/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int Massive(string message)
{
   Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int ArrayLen = Massive("Введите длинну массива: ");
int[] Array = new int[ArrayLen];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 8);
    Console.Write(Array[i] + " ");
}

/* Заполнение массива с клавиатуры:

Console.Clear();

int Massive(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ArrayLen = Massive("Введите количество элементов массива:\t");
int [] Array = new int[ArrayLen];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    Array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nВывод массива:");

for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine(Array[i]);
} 
*/