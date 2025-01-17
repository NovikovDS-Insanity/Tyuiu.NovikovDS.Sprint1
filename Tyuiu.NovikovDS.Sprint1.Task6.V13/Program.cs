﻿using Tyuiu.NovikovDS.Sprint1.Task6.V13.Lib;

DataService ds = new();

Console.Title = "Спринт #1 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
Console.WriteLine("* Проверить, что буквы строки упорядочены по алфавиту.                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string k;
Console.WriteLine("Введите не пустую строку:");
do
{
    k = Console.ReadLine().ToLower();
} while (string.IsNullOrEmpty(k));

bool h = ds.CheckWordsAlphabet(k);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(h);
Console.ReadLine();