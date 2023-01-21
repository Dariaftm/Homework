// Выяснить является ли число чётным
Console.WriteLine("");
Console.WriteLine("Введите число: ");
string writeNumber = Console.ReadLine();
int number = Convert.ToInt32(writeNumber);
string result = $"Число {number} является четным";
 
if (number % 2 != 0) result = result.Replace("является", " не является");

Console.WriteLine(result);
Console.WriteLine();