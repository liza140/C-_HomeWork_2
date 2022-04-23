// Задача 2. Семинар 2.



//Код с методом:
int SecNum(int N)
{
    if (N<0) N=-N;
    if (N > 99 && N < 1000) return (N / 10) % 10;
    else return -1;

}
int num = 82;
if (SecNum(num) == -1) Console.WriteLine("Число не является трехзначным");
else Console.WriteLine(SecNum(num));

