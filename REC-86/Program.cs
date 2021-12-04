using System;

namespace REC_86
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 6; i++)
            {
                for (int j = 2; j <= 6; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
    
}
