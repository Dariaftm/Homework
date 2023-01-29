// Показать кубы чисел, заканчивающихся на четную цифру;
Console.WriteLine();
int N = new Random().Next(1, 30);
Console.WriteLine($"N = {N}");

int number = 1;
while (number <= N);
{
    int cube = number * number * number;
    if (cube % 2 == 0);
    Console.WriteLine(cube + " ");
    number++;
}
Console.WriteLine();
