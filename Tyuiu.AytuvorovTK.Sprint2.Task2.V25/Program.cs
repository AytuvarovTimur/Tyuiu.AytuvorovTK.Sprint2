using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint2.Task2.V25.Lib;


namespace Tyuiu.AytuvorovTK.Sprint2.Task2.V25;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

        Console.WriteLine(" Введите значение переменной X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Введите значение переменной Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("*********************************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
        Console.WriteLine("*********************************************************************************************************************");


        if (res)
        {
            Console.WriteLine(" Точка находится в заштрихованной области ");
        }
        else
        {
            Console.WriteLine(" Точка не находится в заштрихованной области ");
        }

        Console.ReadKey();

    }
}