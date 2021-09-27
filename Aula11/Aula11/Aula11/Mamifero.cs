using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            Console.Write("Mamifero \n");
            base.Respiração("Respiração");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Pulmonar. \n");
        }
    }
}
