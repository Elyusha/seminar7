// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
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

void ArithmeticMean(int[,] matrix)
{
    double[] ArithMean = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        ArithMean[i] = Math.Round(sum / matrix.GetLength(0), 1);
        Console.Write($"{ArithMean[i]}  ");
        sum = 0;
    }
}


Console.Write("Введите количество строк в матрице: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] MyMatrix = FillMatrix(m, n);
PrintMatrix(MyMatrix);

Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMean(MyMatrix);

