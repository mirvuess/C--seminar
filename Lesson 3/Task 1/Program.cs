//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

int n = Convert.ToInt32(Console.ReadLine());
int [] mas = new int [n];

//Console.WriteLine(mas);

//while

int i = 0;

while (i < mas.Length)
{
    Console.Write($"{mas[i]} ");
    i++;
}

Console.WriteLine();

//for

// for (int i = 0; i < mas.Length; i++)
// {
//     Console.Write($"{mas[i]} ");
// }

// Console.WriteLine();

//foreach

foreach (int item in mas)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

//function

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
}

PrintMas(mas);

int [] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,9);
    }
    
    return col;
}

int [] new_mas = RandomMas(mas);
PrintMas(new_mas);

Console.WriteLine("Insert number: ");
int m = Convert.ToInt32(Console.ReadLine());


int flag = 0;
foreach (var item in new_mas)
{
    if (item == m)
    {
        flag++;
    }
}

if (flag > 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


string Smart(int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m) return "Yes";
    }
    return "No";
}

Console.WriteLine(Smart(new_mas, m));