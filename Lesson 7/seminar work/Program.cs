// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumNum(int num)
{
    if (num == 0)
    {
        return 0;
    }

    int res = num % 10 + SumNum(num / 10);
    return res;
}



Console.WriteLine("Insert number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));


// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string Len(int stop, int start = 1)
{
    if (start == stop)
    {
        return Convert.ToString(stop);
    }
    return start + " " + Len(stop, start + 1);
}

void PrintLen(int num)
{
    if (num == 0)
    {
        return;
    }
    PrintLen(num - 1);
    Console.Write($"{num} ");
}



Console.WriteLine("Insert number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Len(n));
PrintLen(n);


// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.

void Consonants(string s)
{
    if (s.Length == 0) return;
    string st = "aoyuei";
    if (st.Contains(s[0]) == false) Console.Write($"{s[0]}");
    Consonants(s[1..]);

}

void Consonants2(string s, int i = 0)
{
    string st = "aoyuei";
    if (i == s.Length) return;
    if (!st.Contains(s[i])) Console.Write($"{s[i]}");
    Consonants2(s, i + 1);
}


string st = Console.ReadLine()!;
Consonants(st);
Console.WriteLine();
Consonants2(st);


