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
            string[][] arrayChars = new string[6][];
            for (int i = 0; i < 6; i++)
            {
                arrayChars[i] = new string[rd.Next(2, 10)];
                for (int y = 0; y < arrayChars[i].Length; y++)
                {
                    arrayChars[i][y] = Word(rd);
                }
            }
            //Пункт 2
            Console.WriteLine("Массив:");
            foreach (string[] i in arrayChars)
            {
                foreach (string y in i) Console.Write(y + " ");
                Console.WriteLine();
            }
            //Пункт 3
            string[] values = new string[6];
            int count = 0;
            foreach (string[] i in arrayChars)
            {
                values[count] = i[i.Length - 1];
                count++;
            }
            Console.WriteLine("Последние элементы каждой строки :");
            foreach (string i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Пункт 4 
            count = 0;
            foreach (string[] i in arrayChars)
            {
                values[count] = i.Max();
                count++;
            }
            Console.WriteLine("Максимальные значения строк :");
            foreach (string i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Пункт 5
            count = 0;
            foreach (string[] i in arrayChars)
            {
                int k = Array.IndexOf(i, values[count]);
                i[k] = i[0];
                i[0] = values[count];
                count++;
            }
            Console.WriteLine("Новый массив:");
            foreach (string[] i in arrayChars)
            {
                foreach (string y in i) Console.Write(y + " ");
                Console.WriteLine();
            }
        }

        private static string Word(Random rd)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string word = "";
            for (int i = 1; i <= rd.Next(1, 10); i++)
            {
                char c = letters[rd.Next(0, letters.Length)];
                word += c;
            }
            return word;
        }
    }
   
}