using System;

namespace Exe13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base maior");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da base menor");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura");
            double h = Convert.ToDouble(Console.ReadLine());

            if ((b > 0) && (B > 0) && (h > 0))
            {
                double area = ((b + B) * h) / 2;
                Console.WriteLine("Área = " + area);
            }
            else
                //if (!((b > 0) && (B > 0) && (h > 0) ))
                Console.WriteLine("Valor inválido ");
        }
    }
}
