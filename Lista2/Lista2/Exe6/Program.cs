using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as duas notas do aluno");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (((x >= 0.0) && (x <= 10.0)) && ((y >= 0.0) && (y <= 10.0)))
                Console.WriteLine("Média: " + ((x+y)/2));
            else
                Console.WriteLine("Nota inválida");
        }
    }
}
