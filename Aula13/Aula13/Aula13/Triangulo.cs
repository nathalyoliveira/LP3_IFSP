using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Triangulo : IForma
    {
        private double bases;
        private double altura;

        public Triangulo(double bases, double altura)
        {
            this.bases = bases;
            this.altura = altura;

        }
        public double calcularArea()
        {
            return (bases * altura) / 2;
        }
    }
}
