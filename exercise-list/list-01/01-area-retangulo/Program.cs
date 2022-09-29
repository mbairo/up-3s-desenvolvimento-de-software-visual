// Exercício 01
// Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.

using System;

namespace AreaDoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("\n--- Calculo da área do retângulo ---");
                Console.Write("Informe a Largura: ");
                double largura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                
                Calculos calculos = new Calculos();
                Console.WriteLine("Área do triângulo: " + calculos.calculaArea(largura, altura));

            } catch (Exception erro)  {
                Console.WriteLine("Menssagem de erro do Tray-Catch: " + erro.Message);
            } finally {
                Console.WriteLine("\n### Programa finalizado. Tenha um bom dia! ###");
            }
            
        }
    }
}




