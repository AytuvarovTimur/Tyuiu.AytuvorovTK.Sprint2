using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint2.Task5.V14.Lib;


namespace Tyuiu.AytuvorovTK.Sprint2.Task5.V14;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

        Console.WriteLine(" Введите номер дня в году: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер дня недели 1 января: ");
        int firstDay = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((day < 1) || (day > 365) || (firstDay < 1) || (firstDay > 7))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "День недеdли:" + ds.FindDayName(day, firstDay);
        }

        Console.WriteLine("*********************************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
        Console.WriteLine("*********************************************************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();

    }
}

