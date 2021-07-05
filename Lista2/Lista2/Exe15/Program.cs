using System;

namespace Exe15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade do trabalhador: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tempo de serviço do trabalhador: ");
            int tempo = Convert.ToInt32(Console.ReadLine());

            if (idade >= 65)
                Console.WriteLine("Pode se aposentar.");
            else
                if (tempo >= 30)
                Console.WriteLine("Pode se aposentar.");
            else
                if ((idade >= 30) && (tempo >= 25))
                Console.WriteLine("Pode se aposentar.");
            else
                Console.WriteLine("Não pode se aposentar.");
        }
    }
}
