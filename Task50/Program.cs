// Задача 50.Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве или же указание,
// что такого элемента нет.


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

void PrintSum(int[,] inArray, int number)
{
    bool tr = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (number == inArray[i, j])
            {
                tr = true;
            }
        }
    }

    if (tr == true)
    {
        Console.WriteLine($"Число = {number} - есть в массиве");
    }

    if (tr == false)
    {
        Console.WriteLine($"Число = {number} -  нет такого числа");
    }
}

Console.Clear();
Console.Write("Введите колличество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число которое хотите найти: ");
int number = int.Parse(Console.ReadLine()!);
PrintSum(array, number);

