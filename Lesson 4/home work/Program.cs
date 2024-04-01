//task 1 

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");

            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsEvenSum(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершается.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная. Продолжайте ввод.");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение. Попробуйте ещё раз.");
            }
        }
    }

    static bool IsEvenSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum % 2 == 0;
    }
}


//task 2

using System;

class Program
{
    static void Main(string[] args)
    {
        int arraySize = 10;

        Random random = new Random();

        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(100, 1000); 
        }

        Console.WriteLine("Массив случайных трехзначных чисел:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int countEven = CountEvenNumbers(array);
        Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}

//task 3

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }
}









