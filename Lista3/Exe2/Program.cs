using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando a estrutura For: ");
            for(int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Utilizando a estrutura While: ");
            int z = 1;
            while (z <= 100)
            {
                Console.WriteLine(z);
                z++;
            }

            Console.WriteLine("Utilizando a estrutura do-while: ");
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 100);
        }
    }
}
