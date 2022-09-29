using System;

namespace MediaMedianaModa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Programa para a realização do calculo da: Média - Mediana - Moda ---");
            double[] numeros = { 14, 7, 55, 12, 2, 13, 7};
            
            CalculaMedia calculaMedia = new CalculaMedia();
            calculaMedia.mostraMedia(numeros);

            CalculaMediana calculaMediana = new CalculaMediana();
            calculaMediana.mostraMediana(numeros);

            CalculaModa calculaModa = new CalculaModa();
            calculaModa.mostraModa(numeros);

            Console.WriteLine();
        }
    }
}