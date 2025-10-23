using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint2.Task6.V3.Lib;


namespace Tyuiu.AytuvorovTK.Sprint2.Task6.V3;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

        Console.WriteLine(" Введите номер дня недели: ");
        int numNed = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((numNed < 1) || (numNed > 7))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "номер дня недели:" + ds.FindDayName(numNed);
        }


        Console.WriteLine("*********************************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
        Console.WriteLine("*********************************************************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();

    }
}