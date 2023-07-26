// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

string FindElementOfArray(int[,] arr, int m, int n)
{
    return Convert.ToString(arr[m, n]);
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

Console.Write("Матрица 3х4. Нумерация от 0. Введите строку элемента:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента:");
int n = Convert.ToInt32(Console.ReadLine());

string Res = "";
if (m < 0 || m > 2 || n < 0 || n > 3)
{
    Res = "Такого числа в массиве нет";
}
else
{
    Res = FindElementOfArray(arr, m, n);
}

Console.WriteLine(Res);