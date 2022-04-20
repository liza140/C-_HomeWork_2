// Задача 1. Семинар 2.

int MaxNum(int N)
{
    int a = N % 10;
    int b = N / 10;
    int max = a;
    if (b > max) max = b;
    return max;
}
int Num = new Random().Next(10, 100);
Console.WriteLine(Num);
Console.WriteLine(MaxNum(Num));
