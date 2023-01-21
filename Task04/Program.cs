// Найти максимальное из трех чисел
int[] numbers = {698, 25, 125};
int GetMaxNumber(int[] array)                  // выводит номер максимальное значение 
{
     int max = 0;
     for (int i = 0; i < 3; i++)
    {   
       if (numbers[i] > max) max = numbers[i];
    }
       
    return max;              // возвращает максимальное значение
}   

Console.WriteLine();
int maxNumber = GetMaxNumber(numbers);
Console.WriteLine($"Максимальное число: {maxNumber}");
Console.WriteLine();
