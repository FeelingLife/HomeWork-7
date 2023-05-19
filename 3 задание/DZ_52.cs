// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Код при помощи методов методов

int[,] CreatArray(int rows, int columns) // Создаем массив с выполненной задачей
{
    Console.WriteLine("Количество строк массива: " + rows + " ");
    Console.WriteLine("Количество столбцов массива: " + columns + " ");
    Console.WriteLine();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
    double result = 0;
    int counter = 1; // счетчик
    for (int j = 0; j < array.GetLength(1); j++, counter++)
    {
        for (int i = 0; i < array.GetLength(0); i++) // Суммируем значение столбцов
        {
            result = result + array[i, j];
        }
        result = result / columns; // Вычисляем среднее арифмитическое
        result = Math.Round(result, 2);
        Console.Write($"Среднее арифмитическое элементов {counter} столбца: ({result})");
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] array) // Cоздаем вывод массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] array = CreatArray(5, 5); // Задаем размерность массива
Console.WriteLine();
PrintArray(array); // Выводим массив
Console.WriteLine();

// Код без методов

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = new Random().Next(0, 21);
//     }
// }
// Console.WriteLine(" ");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");
// double result = 0;
// for (int j = 0; j < array.GetLength(1); j++ )
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         result = result + array[i, j];
//     }
//     result = result / columns;
//     result = Math.Round(result, 2);
//     Console.Write($"Среднее арифмитическое элементов: ({result})");
//     Console.WriteLine();
// }