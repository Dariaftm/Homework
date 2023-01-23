// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число ");
string writeNumber1 = Console.ReadLine()!;
int number1 = Convert.ToInt32(writeNumber1); // команда, для перевода строки в число

Console.WriteLine("Введите второе число: ");
string writeNumber2 = Console.ReadLine()!;
int number2 = Convert.ToInt32(writeNumber2);

string txtResult = $"Число {number1} не является квадратом числа {number2} "; //  - выводим результат

if (number1 == number2 * number2 )
{
    txtResult = txtResult.Replace(" не", ""); // при выполнении услловий выводит текст без "не"// замена текста
}

Console.WriteLine(txtResult);
Console.WriteLine();
