//task 1

using System;

class UserInputToCompileForTest
{ 
    // Находит элемент по его позиции в массиве
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        // Проверяем, если позиции находятся в пределах массива
        if (ValidatePosition(array, x, y))
        {
            return array[x - 1, y - 1]; // Возвращаем значение элемента, учитывая, что позиции считаем от единицы
        }
        else
        {
            return -1; // Если позиция не валидна, возвращаем -1, что обозначает отсутствие элемента
        }
    }

    // Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        return x > 0 && x <= array.GetLength(0) && y > 0 && y <= array.GetLength(1);
    }

    // Вывод результата
    public static void PrintResult(int[,] array, int x, int y)
    {
        if (ValidatePosition(array, x, y))
        {
            Console.WriteLine($"{FindElementByPosition(array, x, y)}");
        }
        else
        {
            if (x <= 0 || x > array.GetLength(0))
            {
                Console.WriteLine("Position along rows is out of bounds");
            }
            else
            {
                Console.WriteLine("Position along columns is out of bounds");
            }
        }
    }
}

class Answer
{
    public static void Main(string[] args)
    {   
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;
            
            UserInputToCompileForTest.PrintResult(array, x, y);
        }                
    }
}


//task 2

using System;

class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        int[,] newArray = new int[rowCount, colCount];

        // Копируем последнюю строку в новый массив
        for (int j = 0; j < colCount; j++)
        {
            newArray[0, j] = array[rowCount - 1, j];
        }

        // Копируем остальные строки в новый массив
        for (int i = 1; i < rowCount - 1; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                newArray[i, j] = array[i, j];
            }
        }

        // Копируем первую строку в новый массив
        for (int j = 0; j < colCount; j++)
        {
            newArray[rowCount - 1, j] = array[0, j];
        }

        return newArray;
    }

    public static void PrintResult(int[,] numbers)
    {
        int[,] swappedArray = SwapFirstLastRows(numbers);
        PrintArray(swappedArray);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}


//task 3

using System;

class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        int[] rowSums = new int[rowCount];

        for (int i = 0; i < rowCount; i++)
        {
            int sum = 0;
            for (int j = 0; j < colCount; j++)
            {
                sum += array[i, j];
            }
            rowSums[i] = sum;
        }

        return rowSums;
    }

    // Получение индекса строки с минимальной суммой элементов
    public static int MinIndex(int[] array)
    {
        int minIndex = 0;
        int minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minIndex = i;
                minValue = array[i];
            }
        }

        return minIndex;
    }

    public static void PrintResult(int[,] numbers)
    {
        int[] rowSums = SumRows(numbers);
        int minIndex = MinIndex(rowSums);

        // Выводим индекс строки с наименьшей суммой элементов, начиная с единицы
        Console.WriteLine(minIndex);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}


