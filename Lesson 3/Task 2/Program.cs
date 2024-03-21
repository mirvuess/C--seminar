//Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на положительные, а положительные на отрицательные.

int[] Append()
{
    int[] list = new int[10];
    for (int i = 0; i < 10; i++)
    {
        var rand = new Random();
        list[i] = rand.Next(-10, 11);
    }
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    return list;
}

int[] Check(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = list[i] * (-1);
    }
    return list;
}

var lst = Append();
var newLst = Check(lst);


Console.WriteLine();
foreach (var item in newLst)
{
    Console.Write(item + " ");
}

//

using System.ComponentModel.DataAnnotations;

int n = Convert.ToInt32(Console.ReadLine());

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-10, 11);
    }

    return col;
}

int[] arr = RandomMas(new int[n]);
PrintMas(arr);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;

}

PrintMas(arr);

//Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

int[] Append(int len)
{
    int[] list = new int[len];
    for (int i = 0; i < len; i++)
    {
        list[i] = new Random().Next(-100, 101);
    }
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    return list;
}

var len = 6;

var lst = Append(len);

int index = 0;

while (index < lst.Length / 2)
{
    Console.Write(lst[index] * lst[lst.Length - index - 1] + " ");

    index++;
}

//Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.

string n = Console.ReadLine();
int len = n.Length;

int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    arr[i] = Convert.ToInt32(Convert.ToString(n[i]));
}

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

PrintMas(arr);

int[] arr2 = new int[len];

for (int i = 0; i < len; i++)
{
    arr2[i] = Convert.ToInt32(Convert.ToString(n[len - 1 - i]));
}

PrintMas(arr2);

//

string num = Console.ReadLine();

int[] list = new int[num.Length];
int[] listReverse = new int[num.Length];

for (int i = 0; i < num.Length; i++)
{

    char n = num[i];
    list[i] = Convert.ToInt16(Convert.ToString(n));
    listReverse[i] = Convert.ToInt16(Convert.ToString(num[num.Length - i - 1]));
    Console.WriteLine(n);
}

Console.WriteLine();