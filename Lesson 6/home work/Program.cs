//task 1

char[,] letter = new char[,] { { 'H', 'e', 'l', 'l', 'o' }, { 'W', 'o', 'r', 'l', 'd' } };

int rows = letter.GetLength(0);
int cols = letter.GetLength(1);

string result = "";

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        result += letter[i, j];
    }
}

Console.Write("Результирующая строка: " + result);


//task 2

string uppercase = "HELLO WORLD";

string resultString = "";

foreach (char c in uppercase)
{
    if (char.IsUpper(c))
    {
        resultString += char.ToLower(c);
    }
    else
    {
        resultString += c;
    }
}

Console.WriteLine();
Console.WriteLine("Результирующая строка: " + resultString);


//task 3


string inputLetter = "level";

string reversedString = ReverseString(inputLetter);

bool isPalindrome = inputLetter.Equals(reversedString, StringComparison.OrdinalIgnoreCase);

if (isPalindrome)
{
    Console.WriteLine("Строка \"" + inputLetter + "\" является палиндромом.");
}
else
{
    Console.WriteLine("Строка \"" + inputLetter + "\" не является палиндромом.");
}

string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


//task 4


string inputString = "это пример строки для тестирования";

// Разбиваем строку на массив слов, используя пробел в качестве разделителя
string[] words = inputString.Split(' ');

// Создаем пустую строку для хранения результата
string resultString = "";

// Проходим по массиву слов в обратном порядке и добавляем их к результату, разделяя пробелами
for (int i = words.Length - 1; i >= 0; i--)
{
    resultString += words[i] + " ";
}

// Удаляем лишний пробел в конце строки
resultString = resultString.Trim();

// Выводим результат
Console.WriteLine("Результирующая строка: " + resultString);