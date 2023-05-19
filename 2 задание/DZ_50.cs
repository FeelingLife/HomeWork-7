// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Код при помощи методов методов

int[,] CreatArray(int rows, int columns) //Создаем массив с выполненной задачей
{
    Console.WriteLine("Количество строк массива: " + rows + " " );
    Console.WriteLine("Количество столбцов массива: " + columns + " " );
    Console.Write("Введите искомое число: ");
    int finder = int.Parse(Console.ReadLine());
    int[,] array = new int[rows, columns];
    int q = 0; // счетчик
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 21);
            if (finder == array[i, j])
            {
                Console.WriteLine();
                Console.WriteLine($"Индексы числа в двумерном массиве: ({i + 1},{j + 1}) ");
                q++;
            }
        }
    }
    if (q == 0)
    {
        Console.WriteLine($"{finder} - такого числа в масссиве нет");
    }
    return array;
}
void PrintArray(int[,] array) //создаем вывод массива на экран
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
int[,] massive = CreatArray(5, 5);
Console.WriteLine();
PrintArray(massive);
Console.WriteLine();

// Код без методов

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