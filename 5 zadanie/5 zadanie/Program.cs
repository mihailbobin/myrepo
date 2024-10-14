using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"x = {F(2, 2, 5, 5) + F(3, 3, 7, 5) + F(5, 5, 11, 11)}");
            Console.ReadKey();
        }

        static double F(double x1, double x2, double x3, double x4)
        {
            return ( (x1 + Math.Sin(x2)) / (x3 + Math.Cos(x4)) );
        }
        
    }
}
