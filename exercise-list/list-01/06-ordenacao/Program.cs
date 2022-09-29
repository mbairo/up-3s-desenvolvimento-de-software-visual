// Exercício 06
// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior. 
//  a) Desenvolver o algoritmo de ordenação;
//  b) Utilizar uma função em C# para ordenação;	

using System;
namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("\n--- Ordenação de 1000 números do menor para o maior ---");
            
            int [] arrayNum = new int [1000];
            
            for (int cont = 1; cont < arrayNum.Length; cont++)
            {
                arrayNum [cont] = random.Next(1000);
            }
            Array.Sort(arrayNum);
            for (int cont = 0; cont < arrayNum.Length; cont++)
            {
                Console.Write(arrayNum[cont] + ", ");
            }
            Console.WriteLine();
        }   
    }
}