//14 Напишите программу, которая принимает на вход число и 
//проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите проверочное число");
int firstNumber = int.Parse(Console.ReadLine()!);

void numbers(int firstNumber)
{
    int result = firstNumber % 7;
    int result2 = firstNumber % 23;
    if (result == 0 && result2 == 0)
        {
            Console.WriteLine("Кратно");
        }
        else
        {
            Console.WriteLine("Нет");
        }
}

// int firstNumber = int.Parse(Console.ReadLine()!);
numbers(firstNumber);