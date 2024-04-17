//task 1

using System;

class Program
{
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write($"{m} ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {m} до {n}:");
        PrintNaturalNumbers(m, n);
    }
}

//task 2

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно {result}");
    }
}

//task 3

using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{arr[index]} ");
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(array, array.Length - 1);
    }
}


