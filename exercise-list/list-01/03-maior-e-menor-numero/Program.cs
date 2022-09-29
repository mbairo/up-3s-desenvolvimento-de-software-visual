// Exercício 03
// Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior. 

using System;
namespace MaiorEMenorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Maior e Menor Número Digitado ---");
            Console.Write("Informe o 1° número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o 2° número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            VerificaNumeros verificaNumeros = new VerificaNumeros ();
            Console.WriteLine("\nResultado: ");
            verificaNumeros.mostraResultado(num1, num2);
        }
    }
}
