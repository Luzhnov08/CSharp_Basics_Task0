/* Задача 43.Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Нахождение точки пересечения двух прямых.\nВвод координат точки 1");
Console.WriteLine("Введите целое число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод координат точки 2");
Console.WriteLine("Введите целое число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

PrintCrossPoints(b1,k1,b2,k2);

void PrintCrossPoints(int bc1, int kc1, int bc2, int kc2) 
{
    double x = ((double)bc1 - bc2) / (kc2 - kc1);
    double y = kc1 * x + bc1;

    Console.WriteLine($"b1 = {bc1}, k1 = {kc1}, b2 = {bc2}, k2 = {kc2} -> ({x}; {y})");
}
