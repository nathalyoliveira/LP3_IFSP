using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Triangulo : Forma
    {

        private double bases;
        private double altura;

        public Triangulo(double bases, double altura)
        {
            base.setCor("Amarelo");
            this.bases = bases;
            this.altura = altura;
            Console.WriteLine("Área do triangulo: " + this.calcularArea());

        }
        public override double calcularArea()
        {
            return (bases * altura) / 2;
        }
    }
}
