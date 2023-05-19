// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

int MethodPrintNumbers(int finder, int rows, int columns)
{
    Console.WriteLine();
    {
        Console.WriteLine($"Bесомое число: {finder}");
        return finder;
    }
    {
        Console.WriteLine($"Количество строк массива: {rows}");
        return rows;
    }
    {
        Console.WriteLine($"Количество столбцов массива: {columns}");
        return columns;
    }
    Console.WriteLine();
}

int[,] array = new int[rows, columns];
int q = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(0, 21);
        if (finder == array[i, j])
        {
            Console.WriteLine($"Индексы числа в двумерном массиве: ({i + 1},{j + 1}) ");
            q++;
        }
    }
}
if (q == 0)
{
    Console.WriteLine($"{finder} - такого числа в масссиве нет");
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Console.WriteLine();
// Console.Write("Введите искомое число: ");
// int finder = int.Parse(Console.ReadLine());

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine();

// int[,] array = new int[rows, columns];
// int q = 0;

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = new Random().Next(0, 21);
//         if (finder == array[i, j])
//         {
//             Console.WriteLine($"Индексы числа в двумерном массиве: ({i+1},{j+1}) ");
//             q++;
//         }
//     }
// }
// if (q == 0)
// {
//     Console.WriteLine($"{finder} - такого числа в масссиве нет");
// }
// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();