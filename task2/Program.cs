// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] FillMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],10}");
        }
        Console.WriteLine();
    }
}

void FindNum(double[,] matr, int row, int column)
{
    if (row > matr.GetLength(0) || column > matr.GetLength(1)) Console.WriteLine("Такого числа в матрице нет");
    else Console.WriteLine($"Ваше число на позиции ({row},{column}) -> {matr[row, column]}");
}

Console.Write("Введите количество строк в матрице: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] MyMatrix = FillMatrix(m, n);
PrintMatrix(MyMatrix);

Console.Write("Введите позицию по строке матрицы: ");
int PosRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию по столбцу матрицы: ");
int PosColumn = Convert.ToInt32(Console.ReadLine());
FindNum(MyMatrix, PosRow, PosColumn);