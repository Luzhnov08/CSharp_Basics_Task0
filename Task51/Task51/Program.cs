/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1; 1) и т.д. */

int[,] matrixArr = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(matrixArr);
Sum(matrixArr);

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2},");
            else Console.Write($"{ matrix[i, j],2}");
        }
        Console.WriteLine("]");
    }
}

void Sum(int[,] matr)
{
    int sum = 0;
    //for (int i = 0; i < matr.GetLength(0); i++)
    //{
    //    for (int j = 0; j < matr.GetLength(1); j++)
    //    {
    //        if (i == j) sum+=matr[i,j];
    //    }
    //}

    int size = matr.GetLength(0);
    if(matr.GetLength(0) > matr.GetLength(1)) size = matr.GetLength(1);

    for (int i = 0; i < size; i++)
    {
        int j = i;
        sum += matr[i, j];
    }
    Console.WriteLine();
    Console.WriteLine(sum);
}