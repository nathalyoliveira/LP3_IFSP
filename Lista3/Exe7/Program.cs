using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número par");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<=x; i += 2 )
            {
                Console.WriteLine(i);
            }
        }
    }
}
