using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int x = Convert.ToInt32(Console.ReadLine());

            if(x%2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Ímpar");
        }
    }
}
