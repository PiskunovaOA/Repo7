// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); // количество строк

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов

double[,] matr = FillMatrix(m, n);
PrintMatrix(matr);


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)//цикл перебирает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//цикл перебирает столбцы на каждой строке
        {   
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


double[,] FillMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random random = new Random();
    int max = 10;
    int min = -10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble()
                                        * (max - min) + min, 1);
        }
    }
    return matrix;
}
