using System;

namespace Aula13
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Área da forma: " + forma.calcularArea());
        }
        static void Main(string[] args)
        {
            IForma f1 = new Quadrado(10.0);
            mostrarArea(f1);

            IForma f2 = new Retangulo(6.5, 7.0);
            mostrarArea(f2);

            IForma f3 = new Circulo(7.0);
            mostrarArea(f3);

            IForma f4 = new Triangulo(7.0, 2.5);
            mostrarArea(f4);
        }
    }
}
