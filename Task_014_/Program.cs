// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

void numbers(int firstNumber, int secondNumber)
{
    int result = (firstNumber % secondNumber);
    
    if (result == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно остаток {result}");

    }
}

Console.Clear();
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine()!);

numbers(firstNumber, secondNumber);
