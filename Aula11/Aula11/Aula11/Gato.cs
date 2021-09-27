using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Gato : Mamifero
    {
        public Gato()
        {
            Console.Write(" Gato: ");
            base.Respiração("");
            this.Respiração("");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Esse animal possui respiração com diafragma. ");
        }
    }
}
