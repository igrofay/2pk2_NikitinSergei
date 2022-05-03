using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char[] charSeparators = "".ToCharArray();
            string str2 = string.Join("", str1.Split(charSeparators));
            Console.WriteLine(str2);
        }
    }
}
