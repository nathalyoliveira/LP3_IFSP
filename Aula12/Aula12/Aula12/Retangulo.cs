using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Retangulo : Forma
    {

        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            base.setCor("Vermelho");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Área do retângulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return largura * altura;
        }
    }
}
