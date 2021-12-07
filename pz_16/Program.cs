using System;

namespace pz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            float P, S;
            RectPS(1, 1, 5, 8, out P , out S); // I четверь
            Console.WriteLine($"P={P} , S={S}");
            RectPS(5, -3, 2, -1, out P, out S); // IV четверь
            Console.WriteLine($"P={P} , S={S}");
            RectPS(8, 5, 1, 1, out P , out S); // I четверь
            Console.WriteLine($"P={P} , S={S}");
        }
        static void RectPS(
            float x1,float y1,
            float x2,float y2,
            out float P, out float S
        ) {
            P = (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2;
            S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
        }
    }
}
