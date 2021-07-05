using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine(x + " ao quadrado = " + (x*x));
                double y = Math.Pow(x, 0.5);
                Console.WriteLine( "Raiz quadrada de " + x + " = " +  y);
            } else
                Console.WriteLine("O número é negativo");
        }
    }
}
