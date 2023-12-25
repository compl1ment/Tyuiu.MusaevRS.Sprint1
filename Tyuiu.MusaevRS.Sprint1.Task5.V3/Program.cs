using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание №5                                                              *");
            Console.WriteLine("* Вариант №3                                                              *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая присваивает h третью цифру с конца числа k  *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* k = 123456                                                              *");
            int k = 123456;
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var h = ("* " + ds.Calculate(k));
            Console.WriteLine(h);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
