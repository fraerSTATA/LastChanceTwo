using System.Text;
using core;
using System;
using System.Collections.Generic;

namespace Smirnov
{
    class Program
    {
        delegate string FormatList(List<double> a);


        static void Main(string[] args)
        {
            FormatList Format = delegate (List<double> temp)
            {
                string s = "Корни уравнения: ";
                foreach (double b in temp)
                {
                    s += b.ToString() + " ";
                }
                return s;
            };


            try
            {
                QuadraticEquation a = new QuadraticEquation();
                Console.WriteLine("Введите 3 параметра a b c");
                SmirnovLog.I().Log("Введите 3 параметра a b c");
                double ax = Convert.ToDouble(Console.ReadLine());
                double bx = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());

                SmirnovLog.I().Log($"Введено уравнение : {ax}x +{bx}x + {c} = 0");
                List<double> roots = a.Solve(ax, bx, c);
                SmirnovLog.I().Log(Format(roots));
            }
            catch (SmirnovException ex)
            {
                SmirnovLog.I().Log(ex.Message);
            }
            SmirnovLog.I().Write();
        }
    }
}