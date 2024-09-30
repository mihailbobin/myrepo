using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._09_2_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            string number = Console.ReadLine();
            var num1 = number.Substring(0, 1);
            var num2 = number.Substring(1, 2);
            Console.WriteLine("Измененное число: " + num2 + num1);
            Console.ReadKey();
        }
    }
}
