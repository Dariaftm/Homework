// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Number = new Random().Next(10, 100);
int Max = 0;
int MaxDigit() // максимальная цифра
{
    int DigitOne = Number / 10;
    int DigitTwo = Number % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;
}
MaxDigit();
Console.WriteLine();
Console.WriteLine($" Вчисле {Number} наибольшая цифра {Max}");
Console.WriteLine();
