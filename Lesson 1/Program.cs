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


using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("первое число больше");
        }
        else if (secondNumber > firstNumber)
        {
            Console.WriteLine("второе число больше");
        }
        else
        {
            Console.WriteLine("числа равны");
        }
        
            
        


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}


using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
      return (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);



    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 68;
           b = 9;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}


using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
      if ((number % 2) == 0)
      {
        Console.WriteLine("четное");
      }
      else Console.WriteLine("нечетное");


    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 0;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}


using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      int firstNum = 1;
      while (firstNum <= number)
      {
        if ((firstNum % 2) == 0)
        {
            Console.Write($"{firstNum} ");
        }
        firstNum++;
      }


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 8;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}