using Tyuiu.NovikovDS.Sprint1.Task3.V5.Lib;

DataService ds = new();

Console.Title = "Спринт #1 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,    *");
Console.WriteLine("* изображенными на карте. Ответ округлить до 3 знаков после запятой.      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;

do
{
    Console.WriteLine("Введите масштаб карты (количество км. в одном см.):");
    x = Convert.ToDouble(Console.ReadLine());
    if (x < 0) Console.WriteLine("Масштаб карты не может быть меньше нуля.");
} while (x < 0);

do
{
    Console.WriteLine("Введите расстояние между точками, изображающими населенные пункты (см):");
    y = Convert.ToDouble(Console.ReadLine());
    if (x < 0) Console.WriteLine("Расстояние между точками не может быть меньше нуля.");
} while (x < 0);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.DistanceLength(x, y));
Console.ReadLine();
