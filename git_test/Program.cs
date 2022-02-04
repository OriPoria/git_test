using System;

namespace git_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = 20;
            for (int i = 0; i < loops; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("End of loop!");
            Console.WriteLine("Written by Ori");
        }
    }
}
