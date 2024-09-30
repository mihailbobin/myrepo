using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._09_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длину ребра правильного тетраэдра:");
            var length = double.Parse(Console.ReadLine());
            Console.WriteLine("Объем правильного тетраэдра примерно равен " + Math.Round(Math.Sqrt(2) * length * length * length / 12));
            Console.WriteLine("Площадь поверхности правильного тетраэдра примерно равен " + Math.Round(Math.Sqrt(3) * length * length));
            Console.ReadKey();
        }
    }
}
