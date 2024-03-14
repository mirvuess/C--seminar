// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.

Console.Write("Insert first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2){
    Console.WriteLine($"Square of the {number2} is equal to {number1}");
}
else Console.WriteLine("Square of the {0} is not equal to {1}", number2, number1);

// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.

int N = Convert.ToInt32(Console.ReadLine());
int notN = -N; 

while (notN <= N){
    Console.Write($"{notN} ");
    notN++;
}

// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.

int n = int.Parse(Console.ReadLine());
int firstNum = n/100;
int lastNum = n%10;
int sum = firstNum + lastNum;
Console.WriteLine(sum);
Console.WriteLine((n/10)%10);

//

Console.WriteLine(" введите трехзначное число: ");
string a = Console.ReadLine()!;

if (a.Length != 3)
{
    Console.Write("это не трехзначное число...");
}
else 
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(a[0])) 
                                         + Convert.ToInt32(Convert.ToString(a[2])));
}


//

Console.WriteLine(" введите трехзначное число: ");
string b = Console.ReadLine()!;

if (Convert.ToInt32(b) < 100 || Convert.ToInt32(b) > 1000)
{
    Console.Write("это не трехзначное число...");
}
else 
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(b[0])) 
                                         + Convert.ToInt32(Convert.ToString(b[2])));
}

