using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            Console.Write(" Anfíbio: ");
            base.Respiração("");
            this.Respiração("");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Esse animal possui respiração pulmonar cutânea, ou seja, através da pele. ");
        }
    }
}

