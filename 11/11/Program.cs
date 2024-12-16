using System;
using System.Linq;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст в одну строку:");
            string inputText = Console.ReadLine();

            var words = inputText.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Массив слов:");
            PrintArray(words);

            ChangeFirstLetterToUpper(words);
            Console.WriteLine("\nИзмененный массив слов (первая буква заглавная):");
            PrintArray(words);

            double averageLength = CalculateAverageWordLength(words);
            Console.WriteLine($"\nСредняя длина слов: {averageLength:F2}");

            string[] reversedWords = GetReversedWordsArray(words);
            Console.WriteLine("\nМассив слов с измененным порядком символов:");
            PrintArray(reversedWords);

            Console.ReadKey();
        }

        static void PrintArray(string[] array)
        {
            foreach (var word in array)
                Console.WriteLine(word);
        }

        static void ChangeFirstLetterToUpper(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    array[i] = char.ToUpper(array[i][0]) + array[i].Substring(1);
                }
            }
        }

        static double CalculateAverageWordLength(string[] array)
        {
            if (array.Length == 0)
                return 0;

            int totalLength = array.Sum(word => word.Length);
            return (double)totalLength / array.Length;
        }

        static string[] GetReversedWordsArray(string[] array)
        {
            string[] reversedArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                char[] reversedChars = array[i].ToCharArray();
                Array.Reverse(reversedChars);
                reversedArray[i] = new string(reversedChars);
            }
            return reversedArray;
        }
    }
}
