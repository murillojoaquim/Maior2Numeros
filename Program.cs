using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"O maior número é {n1}");
            }
            else
            {
                Console.WriteLine($"O maior número é {n2}");
            }

        }
    }
}
