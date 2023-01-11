
/*
int[] elements = new int[10];
int sum, index, length, current;

length = elements.Length;
index = 0;
sum = 0;
while (index < length)
{
    current = Random.Shared.Next(30);
    elements[index] = current;

    Console.WriteLine(elements[index]);

    if (current >= 10 && current <= 99)
    {
        {
            sum = sum + current;
        }
    }
    index++;
}
Console.WriteLine("-------------");
Console.WriteLine(sum);
*/

Console.Clear();


int[] CreateArray()
{
    return new int[10];
}

void Fill(int[] elements)
{
    int length = elements.Length;
    int index = 0;
    //int sum = 0;
    while (index < length)
    {
        int current = Random.Shared.Next(30);
        elements[index] = current;
        index++;
    }
}

int GetSum(int[] array)
{
    int size = array.Length;
    int sum = 0;
    int position = 0;

    while(position < size)
    {
        int  current = array[position];
        if (current >= 10 && current <= 99)
        {
            sum = sum + current;
        }
        position = position + 1;
    }
    return sum;
}

string Print(int[] collection)
{
    string output = String.Empty;
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        int current = collection[index];
        output = output +$"{current}";
        index = index + 1;
    }

    return output;
}

int[] arr = CreateArray();
Fill(arr);
int sum = GetSum(arr);
Console.WriteLine(Print(arr));
Console.WriteLine($"sum = {sum}");


