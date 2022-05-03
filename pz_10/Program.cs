using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();//Создаём рандом для создания значений 
            Console.WriteLine("Задание 1");
            int[][] arrayInt = new int[5][];//Создаём массив
            //Заполняем массив
            for (int i = 0; i < 5; i++)
            {
                arrayInt[i] = new int[random.Next(3, 15)];//Создаём ступень массива
                for (int y = 0; y < arrayInt[i].Length; y++)
                {
                    arrayInt[i][y] = random.Next(-50, 50);//Заполняем
                }
            }
            Console.WriteLine("Задание 2");
            //Выводим массив
            Console.WriteLine("Массив:");
            foreach (int[] i in arrayInt)
            {
                foreach (int y in i) Console.Write(y + "  ");//Выводим части ступени
                Console.WriteLine();//"Переходим" на другую ступень
            }
            Console.WriteLine("Задание 3");
            //Находим последние значения
            int[] data = new int[5];
            for (int i = 0; i < 5; i++)
            {
                data[i] = arrayInt[i][arrayInt[i].Length - 1];//Заполняем массив значениями, которые находятся в конце ступеней
            }
            //Выводим массив
            Console.WriteLine("Последние значения:");
            foreach (int i in data)
            {
                Console.Write(i + "\t");//Выводим конечные значения ступений

            }
            Console.WriteLine();//Делаем пробел
            Console.WriteLine("Задание 4");
            //Находим максимальные значения
            for (int i = 0; i < 5; i++)
            {
                data[i] = arrayInt[i].Max();//Находим максимальное значение в ступени и заполняем массив
            }
            //Выводим значения
            Console.WriteLine("Максимальные значения:");
            foreach (int i in data)
            {
                Console.Write(i + "\t");//Выводиммаксимальные значения ступений
            }
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            //Меняем местами значения
            for (int i = 0; i < 5; i++)
            {
                int position = Array.IndexOf(arrayInt[i], data[i]);//Находим позицию, где находится мак. значение
                arrayInt[i][position] = arrayInt[i][0];//Меняем мак. значение на начальное 
                arrayInt[i][0] = data[i];//Меняем начальное знач. на мак.
            }
            Console.WriteLine("Массив:");
            foreach (int[] i in arrayInt)
            {
                foreach (int y in i) Console.Write(y + "  ");//Выводим части ступени
                Console.WriteLine();//"Переходим" на другую ступень
            }
        }
    }
}
