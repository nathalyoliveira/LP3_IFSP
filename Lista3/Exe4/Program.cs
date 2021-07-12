using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<=x;++i)
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
