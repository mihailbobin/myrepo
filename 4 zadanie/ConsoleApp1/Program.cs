using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            var x = int.Parse(Console.ReadLine());
            var y = Math.Sqrt(Math.Pow(2, Math.Pow(x, x)) + Math.Pow(x, Math.Pow(2, x)) + Math.Pow(x, Math.Pow(x, 2)));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
