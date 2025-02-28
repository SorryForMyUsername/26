using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1.5, 2.5);
            a.Print();
            a.SetX(1);
            Console.WriteLine("Обновил значениие x");
            a.Print();
            Console.WriteLine();

            Point b = new Point(-3.8, -4.2);
            b.Print();
            b.SetY(0);
            Console.WriteLine("Обновил значениие y");
            b.Print();
            Console.WriteLine();

            Point c = new Point(0.1, 9.9);
            c.Print();
            double temp = c.GetX();
            c.SetX(c.GetY());
            c.SetY(temp);
            Console.WriteLine("Поменял местами значение х и у");
            c.Print();

            Console.ReadKey(true);
        }
    }
}
