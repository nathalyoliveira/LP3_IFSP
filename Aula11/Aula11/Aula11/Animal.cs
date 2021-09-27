using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Animal { 
    public Animal()
    {
        Console.Write("-> Animal: ");
    }

    protected virtual void Respiração(string respiracao)
    {
        Console.Write("Respiração do ");
    }
    }
}
