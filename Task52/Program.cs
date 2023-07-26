// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverCol(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца (округление до двух знаков после запятой): ");
    
    int strings = arr.GetLength(0);
    int coloumns = arr.GetLength(1);

    for (int j = 0; j < coloumns; j++)
    {
        double sum = 0;
        for (int i = 0; i < strings; i++)
        {
            sum += arr[i, j];
        }
        double aver = Math.Round(sum/strings, 2);
        Console.Write($"{aver}; ");
    }
        Console.Write("\b\b.");
}

int[,] arr = new int[3, 4];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j], 2}");        
    }
    Console.WriteLine();
}

AverCol(arr);