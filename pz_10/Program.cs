using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            //Пункт 1
            char[][] arrayChars = new char[6][];
            for (int i = 0; i < 6; i++)
            {
                arrayChars[i] = new char[rd.Next(2, 10)];
                for (int y = 0; y < arrayChars[i].Length; y++)
                {
                    arrayChars[i][y] = (char)('A' + rd.Next(0, 30));
                }
            }
            //Пункт 2
            Console.WriteLine("Массив:");
            foreach (char[] i in arrayChars)
            {
                foreach (char y in i) Console.Write(y + " ");
                Console.WriteLine();
            }
            //Пункт 3
            char[] values = new char[6];
            int count = 0;
            foreach (char[] i in arrayChars)
            {
                values[count] = i[i.Length - 1];
                count++;
            }
            Console.WriteLine("Последние элементы каждой строки :");
            foreach (char i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Пункт 4 
            count = 0;
            foreach (char[] i in arrayChars)
            {
                values[count] = i.Max();
                count++;
            }
            Console.WriteLine("Максимальные значения строк :");
            foreach (char i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Пункт 5
            count = 0;
            foreach (char[] i in arrayChars)
            {
                int k = Array.IndexOf(i, values[count]);
                i[k] = i[0];
                i[0] = values[count];
                count++;
            }
            Console.WriteLine("Новый массив:");
            foreach (char[] i in arrayChars)
            {
                foreach (char y in i) Console.Write(y + " ");
                Console.WriteLine();
            }
        }
    }
}
