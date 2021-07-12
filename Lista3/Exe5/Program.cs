using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int x = Convert.ToInt32(Console.ReadLine());

            int i = x+1;
            while (i > x)
            {
                if ((i % 11 == 0) || (i % 13 == 0) || (i % 17 == 0))
                {
                    Console.WriteLine(i);
                    break;
                }
                i++;
            }

        }
    }
}
