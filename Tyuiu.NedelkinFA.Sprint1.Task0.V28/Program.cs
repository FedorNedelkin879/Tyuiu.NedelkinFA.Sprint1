﻿using Tyuiu.NedelkinFA.Sprint1.Task0.V28.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Неделькин Ф. А. | ИИПБ-24-1";
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                             *");
Console.WriteLine("* Задание #0                                                                                   *");
Console.WriteLine("* Вариант #28                                                                                  *");
Console.WriteLine("* Выполнил: Неделькин Ф. А. | ИИПБ-24-1                                                        *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                     *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 48/12-48/6/4                                 *");
Console.WriteLine("* и печатает результат на экране.                                                              *");
Console.WriteLine("*                                                                                              *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                             *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* 48/12-48/6/4                                                                                 *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                   *");
Console.WriteLine("************************************************************************************************");

Console.WriteLine(ds.Calculate());

Console.ReadLine();

