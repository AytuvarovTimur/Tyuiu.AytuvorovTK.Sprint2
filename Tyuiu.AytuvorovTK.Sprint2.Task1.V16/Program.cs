using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint2.Task1.V16.Lib;


namespace Tyuiu.AytuvorovTK.Sprint2.Task1.V16;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 145;
        int b = 716;
        int c = 144;
        int d = 137;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d); 

        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
        Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

        Console.WriteLine("A = : " + a);
        Console.WriteLine("B = : " + b);
        Console.WriteLine("C = : " + c);
        Console.WriteLine("D = : " + d);

        Console.WriteLine("*********************************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
        Console.WriteLine("*********************************************************************************************************************");


        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();

    }
}


