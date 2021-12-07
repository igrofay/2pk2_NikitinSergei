using System;

namespace pz_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summ(5));
        }

        static float OneTask(
            int n
        ){
            if (n == 1) return -1;
            else if (n > 0) return OneTask(n - 1) - 0.2f;
            else return OneTask(n + 1) + 0.2f;
        }

        static float TwoTask(
            int n
        ){
            if (n == 1) return 11;
            else if (n > 0) return TwoTask(n - 1) * -3;
            else return TwoTask(n + 1) / -3;
        }

        static float ThreeTask(
            int A, int B
        ){
            if (A == B)
            {
                float value = (float)(79 * Math.Pow(33, B - 1));
                Console.WriteLine($"n={B} b={value}");
                return value;
            }
            else 
            {
                float value = A < B ? ThreeTask(A, B - 1) * 33 : ThreeTask(A, B + 1) / 33;
                Console.WriteLine($"n={B} b={value}");
                return value;
            }
        }
        //Доп задание
        static int Summ(int n)
        {
            if (n == 1) return 1;
            else return Summ(n - 1) + n;
        }
    }
}
