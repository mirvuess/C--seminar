//Задайте массив символов (тип char []). Создайте строку из символов этого массива.

string CharsOfString(char[] arr)
{
    string st = "";
    for (int i = 0; i < arr.Length; i++)
    {
        st += arr[i];
    }
    return st;
}

string CharsOfString2(char[] arr)
{
    string st = "";
    foreach (var i in arr)
    {
        st += i;
    }
    return st;
}


char[] chars = new char[] { 'a', '1', 'c', 'd', 'z' };
//string st = CharsOfString(chars);
Console.WriteLine(CharsOfString(chars));
Console.WriteLine(CharsOfString2(chars));

// string st2 = "12345";
// for (int i = 0; i < st2.Length; i++)
// {
// Console.WriteLine(st2[i]);
// }



//На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
//“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]


using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

void PrintMass(char[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}



string n = Console.ReadLine();
char[] mass = new char[n.Length];
for (int i = 0; i < n.Length; i++)
{
    mass[i] = n[i];
}


PrintMass(mass);


//Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных (aouei).

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int FindVowels(string str)
{
    string vowels = "aoueiуеаояиыюэAOUEIУЕЫАОЭЯИЮ";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.Write("Введите строку: ");
string n = Console.ReadLine()!;
int res = FindVowels(n);
Console.WriteLine(res);