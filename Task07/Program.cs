// Показать последнюю цифру трёхзначного числа
Console.WriteLine();

int number = new Random() .Next(100, 1000);
Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}"); // {number%10} - выводит последнее число 
Console.WriteLine();