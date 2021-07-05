using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if(x>y)
                Console.WriteLine(x + " é maior");
            else
                Console.WriteLine(y + " é maior");
        }
    }
}
