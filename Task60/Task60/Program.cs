/* ЗЗадача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

int[,,] cubeMatrix = CreateCubeArrUniqueInt(2, 2, 2);
PrintMatrix(cubeMatrix, "Сформированный трёхмерный массив:");

int[,,] CreateCubeArrUniqueInt(int row, int col, int depth)
{
    int[,,] cube = new int[row, col, depth];
    int startInt = DateTime.Now.Second/10 + 10;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                cube[i, j, k] = startInt;
                startInt++;
            }
        }
    }
    return cube;
}

void PrintMatrix(int[,,] cube, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                if (k == cube.GetLength(2) - 1)
                {
                    Console.WriteLine($"[{i}, {j}, {k}] {cube[i, j, k]}");
                }
                else Console.Write($"[{i}, {j}, {k}] {cube[i, j, k]} ");                                
            }
        }        
    }
}