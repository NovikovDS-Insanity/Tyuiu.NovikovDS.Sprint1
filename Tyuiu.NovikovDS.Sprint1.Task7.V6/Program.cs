using Tyuiu.NovikovDS.Sprint1.Task7.V6.Lib;

DataService ds = new();

Console.Title = "Спринт #1 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
Console.WriteLine("* Math.Pow((1 + (1 / Math.Pow(x, 2))), x) - (12 * Math.Pow(x, 2) * y)     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
do
{
    Console.WriteLine("Введите значение X:");
    x = Convert.ToDouble(Console.ReadLine());
    if (x == 0) Console.WriteLine("На ноль делить нельзя.");
} while (x == 0);

Console.WriteLine("Введите значение Y:");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));
Console.ReadLine();