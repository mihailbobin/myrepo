using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском языке: ");
            var t = Console.ReadLine();
            Console.WriteLine("Ваш текст на языке Leet: ");
            Console.WriteLine(Leet(t));

            Console.ReadKey();
        }

        static string Leet(String s)
        {
            return s
                .ToUpper()
                .Replace("А", "4")
                .Replace("B", "8")
                .Replace("C", "(")
                .Replace("D", "|)")
                .Replace("E", "3")
                .Replace("F", "|=")
                .Replace("G", "6")
                .Replace("H", "|-|")
                .Replace("I", "!")
                .Replace("J", ")")
                .Replace("K", "|<")
                .Replace("L", "1")
                .Replace("M", "|\\/|")
                .Replace("N", "|\\|")
                .Replace("O", "0")
                .Replace("P", "|>")
                .Replace("Q", "9")
                .Replace("R", "|2")
                .Replace("S", "5")
                .Replace("T", "7")
                .Replace("U", "|_|")
                .Replace("V", "\\/")
                .Replace("W", "\\/\\/")
                .Replace("X", "><")
                .Replace("Y", "'/")
                .Replace("Z", "2");

        }
    }
}
