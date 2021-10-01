using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
            base.setCor("verde");
            Console.WriteLine("Area do circulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return 3.14 * (raio * raio);
        }
    }
}
