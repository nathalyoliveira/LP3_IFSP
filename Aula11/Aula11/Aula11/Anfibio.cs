using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            Console.Write("Anfíbio \n");
            base.Respiração("Respiração");
        }

        protected override void Respiração(string respiracao)
        {
            Console.Write("Pulmonar e por brânquias. \n");
        }
    }
}
