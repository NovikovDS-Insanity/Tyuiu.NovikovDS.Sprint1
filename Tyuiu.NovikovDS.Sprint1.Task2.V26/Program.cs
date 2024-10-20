using Tyuiu.NovikovDS.Sprint1.Task2.V26.Lib;

DataService ds = new();

Console.Title = "Спринт #1 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x, y;

do
{
    Console.WriteLine("Введите количество часов:");
    x = Convert.ToInt16(Console.ReadLine());
    if (x < 0) Console.WriteLine("Количество часов не может быть отрицательным.");
} while (x < 0);

do
{
    Console.WriteLine("Введите количество минут:");
    y = Convert.ToInt16(Console.ReadLine());
    if (y < 0) Console.WriteLine("Количество минут не может быть отрицательным.");
} while (y < 0);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CalculateMinutesSinceStart(x, y));
Console.ReadLine();
