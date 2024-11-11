using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            Console.WriteLine("f(x) = " + Function(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }

        static double Function(double value)
        {
            double result = 0;
            if (Math.Abs(Math.Sin(value)) > value)
            {
                result = Math.Sin(value);
            }
            if (Math.Abs(Math.Sin(value)) == value)
            {
                result = 0;
            }
            if (Math.Abs(Math.Sin(value)) < value)
            {
                result = Math.Sin(value) * (-1);
            }
            return result;
        }
    }
}
