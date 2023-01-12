/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120

Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/


/*
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}


int getExtOfRange(int start,int end)
{
    int ext = 1;
    for (int i = start; i<=end;i++)
    {
        ext = ext*i  ;
    }
    return ext;
}
int end = getUserDate("Enter A");
int ext = getExtOfRange(1,end);
Console.WriteLine(ext);

*/

int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getRandom()
{
    return new Random().Next(0, 2);
}


int[] createMassive(int numberOfarray)
{
    int[] result = new int[numberOfarray];
    
    for (int i = 0; i < numberOfarray; i++)
    {
        result[i] = getRandom();
        

    }
    return result;


}

string showMassive(int[] array)
{
    
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
       
        result = result + $"{array[i]},";

    }
    return result;


}
int numberOfarray = getUserDate("Введите количество элементов");
int[] array = createMassive(numberOfarray);
string strArray = showMassive(array);
Console.WriteLine(strArray);

