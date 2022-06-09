using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, soma;

            Console.WriteLine("Cálculo da soma entre dois números.\n");

            Console.Write("Digite o primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            soma = primeiroNumero + segundoNumero;

            Console.WriteLine($"\nSoma: {soma}");
        }
    }
}