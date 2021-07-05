using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da prestação");
            double prest = Convert.ToDouble(Console.ReadLine());

            if (prest > (sal * 0.2))
                Console.WriteLine("Empréstimo concedido");
            else
                Console.WriteLine("Empréstimo não concedido");
        }
    }
}
