//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] RandomMas(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            col[i, j] = new Random().Next(0, 10);
        }
    }
    return col;
}

void PrintMas(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Sq(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                col[i, j] *= col[i, j];
            }
        }
    }
    return col;
}




Console.Write("Insert the size of m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the size of n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[,] random = RandomMas(arr);
PrintMas(random);
Console.WriteLine();
PrintMas(Sq(random));


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] UpdateList(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            list[i, j] = new Random().Next(0, 10);
        }
    }

    return list;
}
void PrintList(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SerchList(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                list[i, j] *= list[i, j];
            }
        }
    }

    return list;
}

int DiagList(int[,] list, int min)
{
    int res = 0;

    for (int i = 0; i < min; i++)
    {
        res += list[i, i];
    }

    return res;
}

int SerchMin(int[,] list)
{
    if (list.GetLength(0) < list.GetLength(1))
    {
        return list.GetLength(0);
    }
    return list.GetLength(1);
}

Console.Write("Enter size...");
int firstSize = int.Parse(Console.ReadLine());

Console.Write("Enter size2...");
int secondSize = int.Parse(Console.ReadLine());

int[,] list2D = new int[firstSize, secondSize];
list2D = UpdateList(list2D);
PrintList(list2D);
int res = DiagList(list2D, SerchMin(list2D));

Console.WriteLine("sum = " + res);


//Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

int[,] num1 = { { 2, 32, 4, 3 }, { 4, 3, 12, 1 }, { 2, 8, 5, 4 } };

int[] Sum(int[,] num1)
{
    int[] summa = new int[num1.GetLength(0)];

    for (int i = 0; i < num1.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < num1.GetLength(1); j++)
        {
            sum = sum + num1[i, j];

        }
        summa[i] = sum;
    }
    return summa;
}


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
    Console.WriteLine();
}


void Print2(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
    Console.WriteLine();
}


double[] Middle(int[] a, int[,] b)
{
    double[] c = new double[b.GetLength(0)];
    for (int i = 0; i < a.Length; i++)
    {
        c[i] = Convert.ToDouble(a[i]) / Convert.ToDouble(b.GetLength(1));
    }
    return c;
}




int[] num2 = Sum(num1); // после всех циклов функции Sum вернулся одномерный массив сохранен в этот массиве
Print(num2);

double[] num3 = Middle(num2, num1);
Print2(num3);
