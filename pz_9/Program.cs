using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 5;
            int[,] arrayInt = new int[size , size];
            for (int i = 0; i < size ; i++)
            {
                for(int j = 0; j<size; j++)
                {
                    arrayInt[ i , j ] = rand.Next(-10, 10);
                }
            }
            int count = 0;
            for(int x = 0; x < size; x++)
            {
                for(int y = x+1 ; y < size ; y++)//Значения главной диагонали не вкл.
                {
                    if(arrayInt[x , y] < 0)
                    {
                        count++;
                        Console.WriteLine(arrayInt[x,y]+"\t");
                    }
                }
            }
            Console.WriteLine("Квадратная матрица");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arrayInt[j , i]+ "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Кол-во отрицательнах элементов "+count);
        }
    }
}
