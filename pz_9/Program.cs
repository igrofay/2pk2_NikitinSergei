using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = rand.Next(10, 25);
            int[,] arrayInt = new int[size , size];
            for (int i = 0; i < size ; i++)
            {
                for(int j = 0; j<size; j++)
                {
                    arrayInt[ i , j ] = rand.Next(-10, 10);
                }
            }
            int count = 0;
            for(int i = 0 , j = 0; i < size; i++ , j++)
            {
                if (arrayInt[i, j] < 0) count++;
            }
            Console.WriteLine("Квадратная матрица");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arrayInt[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Кол-во отрицательнах элементов "+count);
        }
    }
}
