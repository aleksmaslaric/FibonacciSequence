using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonaccijevo zaporedje\n");
            int fibonacci;
            int f1 = 0, f2 = 1, f3;

            Console.Write("Vnesi koliko izračunov želiš (npr. 20): ");
            fibonacci = int.Parse(Console.ReadLine());

            Console.Write(f1 + " " + f2 + " ");

            for (int i = 2; i < fibonacci; ++i)
            {
                f3 = f1 + f2;
                Console.Write(f3 + $" = {f1} + {f2}\n");

                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine("\nFibonaccijevo zaporedje deluje tako, da sešteje prejšnji dve števili, npr. 0 + 1 = 1, 1 + 1 = 2, 2 + 1 = 3,...");
            Console.WriteLine("Pritisni tipko za izhod iz programa.");

            Console.ReadKey();
        }
    }
}
