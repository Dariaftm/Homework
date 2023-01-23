// По заданному номеру дня недели вывести его название
Console.WriteLine();
string[] Days = {"Понедельник", "Втоник", "Среда", "Четверг", "Пятница", "Суббота", "Вскресенье"};

Console.WriteLine("Введите номер дня недели: ");
string writeDay = Console.ReadLine()!;
bool result = int.TryParse(writeDay, out int dayNumber); // определяет данные номера в день недели

Console.WriteLine();
if (result == false) Console.WriteLine("Число введено неверно");
else if (0 < dayNumber && dayNumber < 8) System.Console.WriteLine($"{dayNumber}-й день недели - {Days[dayNumber - 1]}");
else System.Console.WriteLine("Дня недели с таким номером не существует");
System.Console.WriteLine();