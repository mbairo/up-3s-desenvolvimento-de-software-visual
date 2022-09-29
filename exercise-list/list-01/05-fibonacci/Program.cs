// Exercício 05
// Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. 
// Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13. 

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Sequência Fibonacci ---");
            Console.Write("Informe um número: ");
            int numInformado = Convert.ToInt16( Console.ReadLine());
            Calculos calculos = new Calculos();
            calculos.resultado(numInformado);
            Console.WriteLine();
        }
    }
}