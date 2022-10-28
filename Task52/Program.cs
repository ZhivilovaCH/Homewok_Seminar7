// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Clear();
Console.Write("Введите колличество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

void PrintSum(int[,] inArray)
{

    double temp = 0;
    int n = 0;
    while (n < columns)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {

            }
            temp += inArray[i, n];
        }
        temp /= row;
        Console.Write($"{Math.Round(temp, 2)}\t ");
        temp = 0;
        n++;
    }
}


int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое :");
PrintSum(array);