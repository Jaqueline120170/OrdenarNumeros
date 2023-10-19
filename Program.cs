using System;

namespace OrdenaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número: ");
            int numero1 = Console.ReadKey(true).KeyChar-('0');
            Console.WriteLine(numero1);
            Console.WriteLine("Escribe un número: ");
            int numero2 = Console.ReadKey(true).KeyChar-('0');
            Console.WriteLine(numero2);
            Console.WriteLine("Escribe un número: ");
            int numero3 = Console.ReadKey(true).KeyChar-('0');
            Console.WriteLine(numero3);

            if (numero1 > numero2 && numero1 > numero3)
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine(numero1 + " > " + numero2 + " > " + numero3);
                }
                else
                {
                    Console.WriteLine(numero1 + " > " + numero3 + " > " + numero2);
                }
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine(numero2 + " > " + numero1 + " > " + numero3);
                }
                else
                {
                    Console.WriteLine(numero2 + " > " + numero3 + " > " + numero1);
                }
            }
            else if (numero1 > numero2 && numero1 < numero3)
            {
                Console.WriteLine(numero3 + " > " + numero1 + " > " + numero2);
            }
            else
            {
                Console.WriteLine(numero3 + " > " + numero2 + " > " + numero1);
            }
        }
    }
}