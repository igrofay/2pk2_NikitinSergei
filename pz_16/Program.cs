using System;

namespace pz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            float P, S;
            (P, S) = RectPS(1, 1, 5, 8); // I четверь
            Console.WriteLine($"P={P} , S={S}");
            (P, S) = RectPS(5, -3, 2, -1); // IV четверь
            Console.WriteLine($"P={P} , S={S}");
            (P, S) = RectPS(8, 5, 1, 1); // I четверь
            Console.WriteLine($"P={P} , S={S}");
        }
        static (float P , float S) RectPS(
            float x1,float y1,
            float x2,float y2
        ) {
            float P = (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2;
            float S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
            return (P, S);
        }
    }
}
