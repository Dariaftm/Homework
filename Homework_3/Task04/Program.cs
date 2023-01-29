// Показать кубы чисел, заканчивающихся на четную цифру;
int N = new Random().Next(1, 30);
Console.WriteLine($"N = {N}");

int[] GetEvenCubeArray(int N)
{
    int num = 1;
    int i = 0;
    int[] EvenCubs = new int[N];
    while (num <= N)
    {
        int cube = num * num * num;
        if (cube % 2 == 0)
        {
            EvenCubs[i] = cube;
            i++;
        }
        num++;
    }
    return EvenCubs;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
  Console.WriteLine();
}
PrintArray(GetEvenCubeArray(N));

