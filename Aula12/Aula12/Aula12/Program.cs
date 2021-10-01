using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1 = new Retangulo(4, 5);

            Console.WriteLine("\n");

            Circulo cir1 = new Circulo(2);

            Console.WriteLine("\n");

            Quadrado quad1 = new Quadrado(15.0);
            Quadrado quad2 = new Quadrado(10.0, "vermelho");

            Console.WriteLine("\n");

            Triangulo tri1 = new Triangulo(2, 5);
        }
    }
}