// Вывести квадрат числа 
int number = new Random(). Next(1, 100);
int result = number * number;
Console.WriteLine(result);

//  Ввод числа с клавиатуры
Console.WriteLine("Введите число: ");
string writeNumber = Console.ReadLine();
int number2 = Convert.ToInt32(writeNumber); // преобразует строку в число
Console.WriteLine($"Квадрат числа {number2} = {number2 * number2}"); // выводит текст с указание квадрата числа

