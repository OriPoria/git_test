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
                if (i > 5 && i < 10)
                {
                    Console.WriteLine(i);
                }
            }
            int j = 1;
            if (j == 1)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("End of loop!");
            Console.WriteLine("Written by Ori");
        }
    }
}
