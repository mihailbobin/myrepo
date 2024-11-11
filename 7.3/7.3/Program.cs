using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого коня");
            var whiteKnightPosition = Console.ReadLine();

            int whiteKnightRow, whiteKnightColumn;

            DecodePosition(whiteKnightPosition, out whiteKnightRow, out whiteKnightColumn);

            Console.WriteLine("Введите позицию черного слона");
            var blackBishopPosition = Console.ReadLine();

            int blackBishopRow, blackBishopColumn;

            DecodePosition(blackBishopPosition, out blackBishopRow, out blackBishopColumn);

            if (whiteKnightPosition == blackBishopPosition) // нужно проверить еще находится ли под боем
            {
                Console.WriteLine("Черный слон не может стоять на этой клетке");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите ход белого коня");


            Console.ReadKey();



        }
        
        static bool IsMoveCorrect(string move, string whiteKnightPosition, string blackBishopPosition)
        {

        }



        static void DecodePosition(string position, out int column, out int row)
        {
            column = int.Parse(position[1].ToString());
            row = (int)position[0] - 0x60;
        }
    }
}
