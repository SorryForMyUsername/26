using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2
{
    internal class Point
    {
        /// <summary>
        /// Поле Координата х
        /// </summary>
        double x;
        /// <summary>
        /// Поле Координата у
        /// </summary>
        double y;

        /// <summary>
        /// Статическое поле Кол-во точек.
        /// </summary>
        static int count;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point()
        {
            x = 1.0;
            x = 1.0;
            count++;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="x">Координата х</param>
        /// <param name="y">Координата у</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static Point()
        {
            count = 0;
        }

        /// <summary>
        /// Метод для получения координаты х
        /// </summary>
        /// <returns>Координата х</returns>
        public double GetX() { return x; }

        /// <summary>
        /// Метод для получения координаты у
        /// </summary>
        /// <returns>Координата у</returns>
        public double GetY() { return y; }

        /// <summary>
        /// Метод для уставновления значения координаты х
        /// </summary>
        /// <param name="x"></param>
        public void SetX(double x)
        {
            this.x = x;
        }

        /// <summary>
        /// Метод для уставновления значения координаты у
        /// </summary>
        /// <param name="y"></param>
        public void SetY(double y)
        {
            this.y = y;
        }

        /// <summary>
        /// Метод для вывода внутренних полей класса
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"x = {GetX()}\ty = {GetY()}");
        }
    }
}
