//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round((rnd.NextDouble() * (minValue - maxValue) + maxValue), 2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите колличество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);