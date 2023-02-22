// Найти сумму элементов от M до N, N и M заданы
//Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// m = 1; n = 4 -> 10
// m = 4; n = 8 -> 30

int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(1, 10));

