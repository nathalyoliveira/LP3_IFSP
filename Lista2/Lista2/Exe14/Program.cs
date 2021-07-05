using System;

namespace Exe14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores dos lados do triângulo");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            while ((A + B > C) && (A + C > B) && (B + C > A))
            {
                if((A == B) && (B == C))
                {
                    Console.WriteLine("Equilátero");
                    break;
                }
                else
                    if ((A != B) && (B != C) && (C != A))
                {
                    Console.WriteLine("Escaleno");
                    break;
                }
                else
                    Console.WriteLine("Isóscele");
                    break;
            }

            if(!((A + B > C) && (A + C > B) && (B + C > A)))
                Console.WriteLine("Não é um triângulo");
        }
    }
}
