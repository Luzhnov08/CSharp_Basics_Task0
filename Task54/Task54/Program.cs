/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

namespace Task54
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = CreateMatrixRndInt(3, 3, 10, 99);
            PrintMatrix(array, "Заданный массив:");
            SortRowsMatrixDesc(array);
            PrintMatrix(array, "Преобразованный массив:");
        }

        public static int[,] CreateMatrixRndInt(int row, int col, int min, int max)
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


        public static void PrintMatrix(int[,] matrix, string text)
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

        public static void SortRowsMatrixDesc(int[,] matr)
        {
            int maxRow = matr.GetLength(0);
            int maxCol = matr.GetLength(1);

            for (int row = 0; row < maxRow; row++)
            {
                for (int i = 1; i < maxCol; ++i)
                {
                    int max = matr[row, i];
                    int j = i;
                    while (j > 0 && matr[row, j - 1] < max)
                    {
                        matr[row, j] = matr[row, j - 1];
                        --j;
                    }
                    matr[row, j] = max;
                }
            }
        }
    }
}