using System;

namespace pz_17
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] ar = GeomProgres(5);
            foreach(float i in ar)
            {
                Console.WriteLine(i);
            }
        }
        static float[] GeomProgres(
            int n
        ) {
            float[] array = new float[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = (float)(10 * Math.Pow(2,i-1));
            }
            return array;
        }
    }
}
