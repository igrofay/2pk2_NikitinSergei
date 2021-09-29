using System;
namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 1;
            float h = 0.5f;
            while (1 <= x && x <= 4)
            {
                double y = x + 3 * Math.Pow(x, 2)  - 2.5f * Math.Pow(x, 3) + 0.75f * Math.Pow(x, 4);
                Console.WriteLine("---------------------------------------\t");
                Console.WriteLine($"| x={x} | y={y} |\t");
                Console.WriteLine("---------------------------------------\t");
                x += h;
            }
        }
    }
}
