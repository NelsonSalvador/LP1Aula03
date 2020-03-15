using System;

namespace PrecorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string c = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != c[0])
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
