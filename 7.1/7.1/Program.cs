using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m:");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsChet(m, n));
            Console.ReadKey();
        }

        static bool IsChet(int m, int n)
        {
            return m % 2 == 1 && n % 2 == 1;
        }
    }
}
