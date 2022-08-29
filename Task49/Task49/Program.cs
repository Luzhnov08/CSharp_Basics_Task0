/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
1 4 7 2 -> 1 4 49 2
5 9 2 3    5 81 2 9 
8 4 2 4    64 4 4 4 */

int[,] matrixArr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrixArr, "Заданный массив:");
EvenIndex(matrixArr);
PrintMatrix(matrixArr, "Преобразованный массив:");

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


void PrintMatrix(int[,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},");
            else Console.Write($"{ matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

void EvenIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
        }
    }
}