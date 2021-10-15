using System;
using System.Collections.Generic;
namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arrayInt = new int[rand.Next(10, 25)];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = rand.Next(-10, 10);
            }
            bool calculate = false;
            int sum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (!calculate && arrayInt[i] < 0) calculate = true;
                else if (calculate)
                {
                    sum += Math.Abs(arrayInt[i]);
                }
            }
            Console.Write("Значения массива: ");
            foreach (int i in arrayInt)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine($"\nСумма равна {sum}");
        }
    }
}
