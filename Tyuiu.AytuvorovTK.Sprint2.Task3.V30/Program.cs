using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint2.Task3.V30.Lib;


namespace Tyuiu.AytuvorovTK.Sprint2.Task3.V30;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

        Console.WriteLine(" Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x);

        Console.WriteLine("*********************************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
        Console.WriteLine("*********************************************************************************************************************");

        Console.WriteLine(" Значение функции = : " + res);


        Console.ReadKey();


        Console.ReadKey();

    }
}
