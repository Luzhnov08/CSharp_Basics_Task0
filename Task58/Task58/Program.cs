/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

int[,] matrA = CreateMatrixRndInt(2, 3, 0, 4);
PrintMatrix(matrA, "Заданная матрица A:");
int[,] matrB = CreateMatrixRndInt(3, 2, 0, 4);
PrintMatrix(matrB, "Заданная матрица B:");
Console.WriteLine();

if (RuleOfCalcMatrix(matrA, matrB))
{
    int[,] resArr = MultiplyTwoMatrix(matrA, matrB);
    PrintMatrix(resArr, "Произведение матриц равно: ");
}
else Console.WriteLine("Невозможно перемножить матрицы. Число столбцов матрицы A не совпадает с числом строк матрицы В.");

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

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{ matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

//Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В .

int[,] MultiplyTwoMatrix(int[,] matr1, int[,] matr2)
{
    int maxRowM1 = matr1.GetLength(0);
    int maxColM2 = matr2.GetLength(1);
    int[,] resMatr = new int[maxRowM1, maxColM2];

    int maxColM1 = matr1.GetLength(1);

    for (int k = 0; k < maxColM2; k++) 
    {        
        for (int i = 0; i < maxRowM1; i++) 
        {
            int elem = 0;
            for (int j = 0; j < maxColM1; j++) //maxColM1 = maxRowM2
            {
                elem += matr1[i, j] * matr2[j, k];
                resMatr[i, k] = elem;
            }            
        }
    }
    return resMatr;
}

bool RuleOfCalcMatrix(int[,] matrixA, int[,] matrixB) 
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}