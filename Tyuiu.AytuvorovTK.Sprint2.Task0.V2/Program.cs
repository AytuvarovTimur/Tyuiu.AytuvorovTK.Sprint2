using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint2.Task0.V2.Lib;


namespace Tyuiu.AytuvorovTK.Sprint2.Task0.V2;
    internal class Program
    {
        static void Main(string[] args)
        {
        DataService ds = new DataService();

        int x = 123;
        int y = 123;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            Console.WriteLine("X = : " + x);
            Console.WriteLine("Y = : " + y);

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

