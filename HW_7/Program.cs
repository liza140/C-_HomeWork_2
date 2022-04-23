// Задача 6. Семинар 2.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int NumInit(int N)
{
    if (N / 100 != 0) return N;
    else return -1;
}

int IndArr(int H)
{
    int Num = H;
    int len = 0;
    while (Num != 0)
    {
        Num = Num / 10;
        len++;
    }
    return len;
}

int ThirdNum(int A, int C)
{
    int[] array = new int[C];
    int ind = 0;
    int pos = A;
    while (pos != 0)
    {
        array[ind] = pos % 10;
        ind++;
        pos = pos / 10;
    }
    return array[C - 3];
}
int NNN = 32679;
if (NumInit(NNN) == -1) Console.WriteLine("Третьей цифры нет");
else
{
    int len = IndArr(NNN);
    //Console.WriteLine(len);
    Console.WriteLine(ThirdNum(NNN, len));
}