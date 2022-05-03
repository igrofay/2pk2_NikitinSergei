using System;
using System.Globalization;
using System.IO;

using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            for (int i = 10; i <= 70; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 2");
            char a = 'Г';
            for (int i = 0; i < 8; i += 1)
            {
                Console.Write($"{ a++ } ");
            }
            Console.WriteLine("\nЗадание 3");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(new string('#', 4));
            }
            Console.WriteLine("Задание 4");
            for (int i = 0; i <= 100; i += 4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 5");
            for (int i = 5, j = 64; ; i++, j--)
            {
                Console.WriteLine($"i={i} j={j} разница {j - i}");
                if (Math.Abs(i - j) == 23) break;
            }

        }
    }
}