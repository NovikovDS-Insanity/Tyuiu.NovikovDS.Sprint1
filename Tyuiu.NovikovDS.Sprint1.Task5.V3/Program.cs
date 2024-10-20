using Tyuiu.NovikovDS.Sprint1.Task5.V3.Lib;

DataService ds = new();

Console.Title = "Спринт #1 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи             *");
Console.WriteLine("* положительного целого числа k (например, если k=130985, то h=9).        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите число k:");
int k = Convert.ToInt32(Console.ReadLine());
int h = ds.Calculate(k);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (k < 100) Console.WriteLine("Число меньше трёхзначного.");
else Console.WriteLine(h);
Console.ReadLine();
