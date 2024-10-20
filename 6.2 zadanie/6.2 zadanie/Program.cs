using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = "апельсин";
            var newword = word.Remove(0, 1).Remove(2, 4) + word.Remove(0, 4).Remove(1, 3);
            Console.WriteLine(newword);
            var reversedWord = new string(word.Reverse().ToArray());
            var newword2 = reversedWord.Remove(0, 2).Remove(1, 3) + reversedWord.Remove(2, 6) + word.Remove(0, 2).Remove(3, 3);
            Console.WriteLine(newword2);
            Console.ReadKey();
        }
    }
}
