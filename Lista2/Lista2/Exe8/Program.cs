using System;

namespace Exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o sexo (M ou F)");
            string sexo = Console.ReadLine();

            if(sexo == "M")
                // double peso = ((72.7 * h) - 58);
                Console.WriteLine("Peso ideal: " + ((72.7 * h) - 58));
            else
                // double peso = ((62.1 * h) - 44,7);
                Console.WriteLine("Peso ideal: " + ((62.1 * h) - 44.7));



        }
    }
}
