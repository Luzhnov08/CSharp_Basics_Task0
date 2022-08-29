/* Задание 48: Задайте двумерный массив размера m на n, 
   каждый элемент в массиве находится по формуле A[m,n] = m + n
   Выведите полученный массив на экран 
   m = 3, n = 4.
   0 1 2 3
   1 2 3 4 
   2 3 4 5 
 */

int[,] matrixArr = CreateMatrixRndInt(3, 4);
PrintMatrix(matrixArr);

int[,] CreateMatrixRndInt(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = i+j;
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

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2},");
            else Console.Write($"{ matrix[i, j], 2}");
        }
        Console.WriteLine("]");
    }
}