//homework

//task 1

int number = new Random().Next(1, 999);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} кратно и 7, и 23.");
}
else
{
    Console.WriteLine($"{number} не кратно одновременно 7 и 23.");
}

//task 2

Console.WriteLine("Введите координаты точки (X и Y):");
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());

int quadrant = 0;

if (x > 0 && y > 0)
    quadrant = 1;
else if (x < 0 && y > 0)
    quadrant = 2;
else if (x < 0 && y < 0)
    quadrant = 3;
else if (x > 0 && y < 0)
    quadrant = 4;

Console.WriteLine($"Точка находится в {quadrant}-й координатной четверти.");

//task 3

Console.WriteLine("Введите целое число из отрезка [10, 99]:");
int num = int.Parse(Console.ReadLine());

if (num < 10 || num > 99)
{
    Console.WriteLine("Число не входит в указанный диапазон.");
    return;
}

int firstDigit = num / 10;
int secondDigit = num % 10;

int largestDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine($"Наибольшая цифра числа {num} - это {largestDigit}.");

//task 4 

Console.WriteLine("Введите натуральное число:");
int numBer = int.Parse(Console.ReadLine());

Console.WriteLine("Цифры числа через запятую:");

string numBerString = numBer.ToString();

Console.Write(numBerString[0]);

for (int i = 1; i < numBerString.Length; i++)
{
    Console.Write(", " + numBerString[i]);
}

Console.WriteLine();

