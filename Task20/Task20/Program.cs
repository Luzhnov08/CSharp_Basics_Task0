/* Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21 */

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Pifagor(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками А ({x1},{y1}) и В ({x2},{y2}) = {Math.Round(result, 2)}");

double Pifagor(int xc1, int yc1, int xc2, int yc2) 
{
    return Math.Sqrt((xc2-xc1)*(xc2-xc1)+(yc2-yc1)*(yc2-yc1));
}

