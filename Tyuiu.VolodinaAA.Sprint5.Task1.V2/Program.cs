using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint5.Task1.V2.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint5.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#5 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#5                                                                *");
            Console.WriteLine("* Тема: Класс File. Забор набора данных в текстовый файл                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение,вычислить его значение на промежутке от -5 до 5, занести *");
            Console.WriteLine("* его результаты в таблицу, сохранить в текстовый файл OutPutFileTask1.txt*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение начала отрезка");
            int startValue;
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение конца отрезка");
            int stopValue;
            stopValue = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue,stopValue);
            Console.WriteLine($"Файл: {res} успешно создан!!!!!!!!!");

            Console.WriteLine("+-------------+-------------+");
            Console.WriteLine("|      X      |     f(x)    |");
            Console.WriteLine("+-------------+-------------+");

            string[] y = File.ReadAllLines(res);

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                Console.WriteLine("| {0,6:d}      |   {1,6:f2}    |", x, Convert.ToDouble(y[i]));
            }

            Console.WriteLine("+-------------+-------------+");
            Console.ReadKey();
        }
    }
}
