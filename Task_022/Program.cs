/* Task 22 Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.Clear();
//Console.WriteLine("Введите число: ");
//int N = int.Parse(Console.ReadLine());

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int i = 1;
int N = getUserValue("Введите число: ");

while (i <= N)
{
        Console.Write(Math.Pow(i,2)+ ", ");
        i++;
}

