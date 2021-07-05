using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + " é maior");
                Console.WriteLine("Diferença: " + (x - y));
            }

            else
            {
                Console.WriteLine(y + " é maior");
                Console.WriteLine("Diferença: " + (y - x));
            }
                
        }
    }
}
