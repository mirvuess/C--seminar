//Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве

int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1, 100);
    }
    return Number;
}

void PrintMass(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool Simple(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }
    Console.WriteLine(num);
    return true;
}

int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if (Simple(i)) count++;
    }
    return count;
}


Console.Write("Intup array size:");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMass(n);
PrintMass(mas);
Console.WriteLine($"Number of simple digits in array {Count(mas)}");



//Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

//Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.


int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
        Console.Write($"{col[i]},");
    }

    return col;
}

int Count(int[] col)
{
    int count = 0;

    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] % 10 == 1 && col[i] % 7 == 0)
        {
            Console.WriteLine();
            Console.Write($"Подпадающие числа:{col[i]} ");
            count++;
        }

    }
    return count;

}

int[] mass = RandomMas(arr);
int count = Count(mass);
Console.WriteLine();
Console.WriteLine($"Количество={count}");


//Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.

//Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.


void ListWriter(int n)
{
    int[] list = new int[n];
    int i = 0;
    while (i < n)
    {
        int num = int.Parse(Console.ReadLine());
        if (num >= 0 || num < 10)
        {
            list[i] = num;
        }

        i++;
    }
    Console.WriteLine(NumWriter(list));
}

int NumWriter(int[] list)
{
    int res = 0;
    foreach (int num in list)
    {
        res *= 10;
        res += num;
    }

    return res;
}

int n = int.Parse(Console.ReadLine());

if (n <= 8)
{
    ListWriter(n);
}



