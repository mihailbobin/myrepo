using System;

namespace _7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого коня:");
            var whiteKnightPosition = Console.ReadLine();

            if (!IsPositionCorrect(whiteKnightPosition))
            {
                Console.WriteLine("Некорректная позиция белого коня");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного слона:");
            var blackBishopPosition = Console.ReadLine();

            if (!IsPositionCorrect(blackBishopPosition) || whiteKnightPosition == blackBishopPosition)
            {
                Console.WriteLine("Черный слон не должен стоять на той же клетке, что и белый конь");
                Console.ReadKey();
                return;
            }

            if (IsBishopStrike(whiteKnightPosition, blackBishopPosition))
            {
                Console.WriteLine("Черный слон атакует белого коня");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Черный слон не атакует белого коня");
                Console.WriteLine("Введите предполагаемый ход белого коня:");
                var move = Console.ReadLine();

                if (IsKnightMoveValid(whiteKnightPosition, move))
                    Console.WriteLine("Ход разрешен");
                else
                    Console.WriteLine("Ход запрещен");
            }

            Console.ReadKey();
        }

        static bool IsPositionCorrect(string position)
        {
            if (position.Length != 2)
                return false;

            int row;
            int column;
            DecodePosition(position, out column, out row);
            return column >= 1 && column <= 8 && row >= 1 && row <= 8;
        }

        static bool IsBishopStrike(string knightPosition, string bishopPosition)
        {
            int kr, kc, br, bc;
            DecodePosition(knightPosition, out kc, out kr);
            DecodePosition(bishopPosition, out bc, out br);
            return Math.Abs(kc - bc) == Math.Abs(kr - br);
        }

        static bool IsKnightMoveValid(string startPosition, string movePosition)
        {
            if (!IsPositionCorrect(movePosition))
                return false;

            int startColumn, startRow, moveColumn, moveRow;
            DecodePosition(startPosition, out startColumn, out startRow);
            DecodePosition(movePosition, out moveColumn, out moveRow);
            return (Math.Abs(startColumn - moveColumn) == 2 && Math.Abs(startRow - moveRow) == 1) ||
                   (Math.Abs(startColumn - moveColumn) == 1 && Math.Abs(startRow - moveRow) == 2);
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 0x60;
        }
    }
}
