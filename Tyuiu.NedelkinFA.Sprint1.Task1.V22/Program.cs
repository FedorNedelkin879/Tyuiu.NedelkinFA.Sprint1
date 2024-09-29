using Tyuiu.NedelkinFA.Sprint1.Task1.V22.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Неделькин Ф. А. | ИИПБ-24-1";
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                             *");
Console.WriteLine("* Задание #1                                                                                   *");
Console.WriteLine("* Вариант #22                                                                                  *");
Console.WriteLine("* Выполнил: Неделькин Ф. А. | ИИПБ-24-1                                                        *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                     *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                      *");
Console.WriteLine("* вычисляет результат по формуле (5+x)/(y*x) и выводит его на экран.                           *");
Console.WriteLine("*                                                                                              *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                             *");
Console.WriteLine("************************************************************************************************");

double x, y;

Console.WriteLine("Введите значение X");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                   *");
Console.WriteLine("************************************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey();

