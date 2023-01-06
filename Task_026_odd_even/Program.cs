Console.Clear();

uint oddNumbersCount = 0;
uint evenNumbersCount = 0;

int oddNumbersSum = 0;
int evenNumbersSum = 0;

Console.WriteLine("Ведите первое число диапазона");
int currentValue = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите последнее число диапазона");
int limit = int.Parse(Console.ReadLine());

while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        evenNumbersCount++;
        // evenNumbersSum = evenNumbersSum + currentValue;
        evenNumbersSum += currentValue;
    }
    else
    {
        oddNumbersCount++;
        oddNumbersSum = oddNumbersSum + currentValue;
    }
    currentValue++;
}

Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
Console.WriteLine("Сумма нечетных чисел: " + oddNumbersSum);
Console.WriteLine("Сумма четных чисел: " + evenNumbersSum);
Console.ReadLine();