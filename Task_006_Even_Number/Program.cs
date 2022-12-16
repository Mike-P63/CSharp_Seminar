// Task #6 What number is even?

Console.Clear();

Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine()!);

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + " является: ЧЁТНЫМ");
            }

