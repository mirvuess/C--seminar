//Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num1 = num % 10;
int num2 = num / 100;

int result = num2 * 10 + num1;
Console.WriteLine($"{num} -> {result}");


//Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int second = number % 10;
int third = number / 10 % 10;

Console.WriteLine(Math.Pow(third, second));

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если первое число некратно второму, то программа выводит остаток от деления

string Test(int first, int second)
{
if (second == 0) { return "Деление на 0!"; }

int res = first % second;

if (res == 0)
{
return "Да";
}
else
{
return $"Нет, {res}";
}
}

Console.WriteLine(Test(10,0));


int num-1 = Convert.ToInt32(Console.ReadLine());
int num-2 = Convert.ToInt32(Console.ReadLine());

if (num-2 == 0)
{
    Console.WriteLine("Деление на 0!");
}
else
{
    int res = num-1 % num-2;

    if (res == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine($"Нет, {res}");
    }
}

//Напишите программу, которая выводит третью слева цифру заданного числа или сообщает, что третьей цифры нет.

int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 10;
int num2 = num / 10 % 10;

if (num > 100 && num < 1000)
{
    Console.WriteLine(num1);
}
else if (num > 1000)
{
    Console.WriteLine(num2);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

//

using System;


int num = new Random().Next(0, 10000000);
Console.WriteLine(num);
int res = 0;

if (num < 100) 
{ 
    Console.WriteLine($"третей цифры нет:{num}"); 
}
else
{
    while (num >= 100)
    {
        res = num % 10;
        num /= 10;
        Console.WriteLine($"num:{num}");
        Console.WriteLine($"ответ:{res}");
        Console.WriteLine();
    }
}
