using System;
using System.Collections;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            Console.WriteLine("Digite valores positivos ou um número menor que 0 para sair");
            int x;
            int i = 0;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x >= 0)
                    lista.Add(x);
                i++;
            } while (x >= 0);

            int maior = 0;

            foreach (int l in lista)
            {
                if (l > maior)
                    maior = l;
            }

            int menor = maior;

            foreach (int lt in lista)
            {
                if (lt < menor)
                    menor = lt;
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);

        }
    }
}
