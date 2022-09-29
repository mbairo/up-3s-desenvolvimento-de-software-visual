// Exercício 04  
// Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: 
// se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso. 

using System;
namespace FaixaEtaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma idade de 1 ano pra cima: ");
            double idade = Convert.ToDouble(Console.ReadLine());
            
            VerificaFaixaEtaria verificaFaixaEtaria = new VerificaFaixaEtaria ();
            verificaFaixaEtaria.mostraResultado(idade);
        }
    }
}



            // try 
            // {    
            // }
        
            // catch (Exception erro)
            // {  
            // }

            // static double CalculaArea (double largura, double altura) 
            // {
            //      return largura * altura;
            // }