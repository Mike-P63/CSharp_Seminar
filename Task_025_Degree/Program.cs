//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

int Chislo(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int number1 = Chislo("Введите число A: ");
int number2 = Chislo("Введите число B: ");
Degree(number1, number2);

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}