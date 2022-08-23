/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int res = ConvertDecToBin(a);
Console.WriteLine($"Двоичное число будет: {res}");
//DecToBin(a);

int ConvertDecToBin(int num) 
{
    int result = 0;
    int mult = 1;

    while (a>0) 
    {
        result += a % 2 * mult;
        a /= 2;
        mult *= 10;
    }
    return result;
}

void DecToBin(int n) 
{
    if (n == 0) return;
    DecToBin(n / 2);
    Console.Write(n % 2);
}