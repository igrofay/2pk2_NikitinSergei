using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = rand.Next(10, 25);
            int[][] arrayInt = new int[size][];
            for (int i = 0; i < size ; i++)
            {
                arrayInt[i] = new int[size];
                for (int j = 0; j<size; j++)
                {
                    arrayInt[ i ][ j ] = rand.Next(-10, 10);
                }
            }
            int count = 0;
            for(int x = 0; x < size; x++)
            {
                for(int y = x+1 ; y < size ; y++)//Значения главной диагонали не вкл.
                {
                    if(arrayInt[y][ x] < 0)
                    {
                        count++;
                        Console.WriteLine(arrayInt[y][x] + "\t");
                    }
                }
            }
            Console.WriteLine("Квадратная матрица");
            foreach(int[] i in arrayInt)
            {
                foreach(int y in i)
                {
                    Console.Write(y + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Кол-во отрицательнах элементов "+count);
        }
    }
}
