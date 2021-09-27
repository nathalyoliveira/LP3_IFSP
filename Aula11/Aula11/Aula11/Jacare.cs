using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            Console.Write(" Jacaré: ");
            base.Respiração("");
            this.Respiração("");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Esse animal possui respiração com ventrículos completamente separados. ");
        }
    }
}
