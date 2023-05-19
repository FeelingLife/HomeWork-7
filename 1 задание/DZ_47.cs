//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

void MethodFillingArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine(" ");
    }
}
MethodFillingArray(5, 5);