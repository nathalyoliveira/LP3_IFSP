using System;

namespace Exe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro maior que 0");
            int x = Convert.ToInt32(Console.ReadLine());

            int soma = 0;
            

            if (x > 0)
            {
                while (x != 0)
                {
                    soma = soma + (x % 10);
                    x = x / 10;
                }
                
                Console.WriteLine("Soma: " + soma);
            }
            else
                Console.WriteLine("Numero inválido");
        }
    }
}
