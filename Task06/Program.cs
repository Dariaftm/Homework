// Показать четные числа от 1 до N
Console.WriteLine("Введите число:  ");
string txtN = Console.ReadLine()!;
int endNum = Convert.ToInt32(txtN);
int num = 0;
Console.WriteLine($"Четные числа из диапазона от 1 до {endNum}:");
while (num <  endNum)
{
    num++;
    if (num % 2 ==0) Console.Write($"{num} ");
}
Console.WriteLine(); 
System.Console.WriteLine();
