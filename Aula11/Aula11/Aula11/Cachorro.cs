using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            Console.Write(" Cachorro: ");
            base.Respiração("");
            this.Respiração("");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Esse animal possui respiração com diafragma. ");
        }
    }
}
