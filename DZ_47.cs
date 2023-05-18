//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

int MethodFillingArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[m, n] = new Random().Next(-10, 11);
            Console.Write(array[m, n] + " ");
        }
        return n;
    }
    return m;
}
MethodFillingArray(2, 5);

// void MethodPrintArray(string message)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }


// MethodPrintArray("Так выглядит массив: ");