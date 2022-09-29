// Exercício 02
// Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
//      a) Dólar (1 dólar = 5,17 reais)
//      b) Euro (1 euro = 6,14 reais)
//      c) Peso argentino (1 peso argentino = 0,05 reais)
using System;

namespace CurrencyExchange02
{
    class Program 
    {
        static void Main(string[] args)
        {
           Console.WriteLine("--- Conversor Monetário ---");
           Console.Write("Informe o valor em Real: ");
           double real = Convert.ToDouble(Console.ReadLine());
           Console.Write("Real>>> " + real);
           ConversorDeMoedas conversorDeMoedas = new ConversorDeMoedas(real);
           
        //    conversorDeMoedas.conversor(real);
           Console.WriteLine(conversorDeMoedas);
        }
    }
}
