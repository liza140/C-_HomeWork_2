// Задача 2. Семинар 2.

//Код в соответсвии с алгоритмом:

//int N = 782;
//if (N > 99 && N < 1000) Console.WriteLine((N / 10) % 10);
//else if (N < -99 && N > -1000) Console.WriteLine(((-N) / 10) % 10);
//else Console.WriteLine("Число не является трехзначным");


//Код с методом:
int SecNum(int N)
{
    int sec = -1;
    if (N > 99 && N < 1000) sec = (N / 10) % 10;
    if (N < -99 && N > -1000) sec = ((-N) / 10) % 10;
    return sec;
}
int num = 782;
if (SecNum(num) == -1) Console.WriteLine("Число не является трехзначным");
else Console.WriteLine(SecNum(num));

