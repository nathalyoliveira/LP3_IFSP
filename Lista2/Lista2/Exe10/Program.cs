using System;

namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as 3 notas do aluno");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 * 1 + n2 * 1 + n3 * 2) / 4;

            if (media >= 60)
                Console.WriteLine("Aprovado! Média: " + media);
            else
                Console.WriteLine("Reprovado! Média: " + media);
        }
    }
}
