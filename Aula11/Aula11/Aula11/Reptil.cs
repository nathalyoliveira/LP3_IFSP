using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Reptil : Animal
    {
        public Reptil()
        {
            Console.Write("Réptil \n");
            base.Respiração("Respiração");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Pulmonar, com ventrículos parcialmente divididos.\n");
        }
    }
}
