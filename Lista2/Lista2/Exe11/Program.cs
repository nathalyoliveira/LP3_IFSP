using System;

namespace Exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do trabalho de laboratório do aluno");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da avaliação semestral do aluno");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota do exame final do aluno");
            double n3 = Convert.ToDouble(Console.ReadLine());

                n1 = n1 * 0.2;
                n2 = n2 * 0.3;
                n3 = n3 * 0.5;

                double media = n1 + n2 + n3;

                if ((media >= 0) && (media <= 2.9))
                    Console.WriteLine("Reprovado! Média: " + media);
                else
                    if ((media >= 3) && (media <= 4.9))
                    Console.WriteLine("Recuperação! Média: " + media);
                else
                    if ((media >= 5) && (media <= 10))
                    Console.WriteLine("Aprovado! Média: " + media);
                else
                    Console.WriteLine("Nota inválida ");

            if (!(((n1 >= 0) && (n1 <= 10)) && ((n2 >= 0) && (n2 <= 10)) && ((n3 >= 0) && (n3 <= 10))))
                Console.WriteLine("Nota inválida ");
        }
    }
}
