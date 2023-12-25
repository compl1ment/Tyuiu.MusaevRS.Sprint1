using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint1.Task3.V4.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                       *");
            Console.WriteLine("* Задание №1                                                              *");
            Console.WriteLine("* Вариант №4                                                              *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выполняет указанные расчёты                 *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Цена тетради = 2.75 Цена обложки = 0.5 Количество комплектов = 7        *");
            Console.WriteLine("***************************************************************************");

            double tetr, obl;
            int kol;

            tetr = 2.75;
            obl = 0.5;
            kol = 7;
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* " + ds.PurchaseAmount(tetr, obl, kol));
            Console.ReadLine();
        }
    }
}
