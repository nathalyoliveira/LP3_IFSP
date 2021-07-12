using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.WriteLine("Digite 10 valores");
            for(int i = 1; i <= 10; ++i)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);
        }
    }
}
