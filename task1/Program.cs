// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

Console.Write("Введите количество строк в матрице: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] MyMatrix = FillMatrix(m, n);
PrintMatrix(MyMatrix);
