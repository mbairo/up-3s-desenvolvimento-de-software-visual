using System;

namespace ProgVisual
{
	class Program
	{
		static double ConverteParaIntIngenuo(string valor)
		{
			double numero = 0.0;
			for(int i = 0; i < valor.Length; i++)
			{
				int digito = 0;
				int potencia = (valor.Length - 1) - i;
				if(valor[i] == '0') digito = 0;
				else if(valor[i] == '1') digito = 1;
				else if(valor[i] == '2') digito = 2;
				else if(valor[i] == '3') digito = 3;
				else if(valor[i] == '4') digito = 4;
				else if(valor[i] == '5') digito = 5;
				else if(valor[i] == '6') digito = 6;
				else if(valor[i] == '7') digito = 7;
				else if(valor[i] == '8') digito = 8;
				else if(valor[i] == '9') digito = 9;
				else throw new Exception("valor invalido");
				numero += digito * Math.Pow(10, potencia);
			}
			return numero;
		}
		
		static double ConverteParaIntEsperto(string valor)
		{
			double numero = 0.0;
			for(int i = 0, j = valor.Length - 1; i < valor.Length; i++, j--)
			{
				if(valor[i] < 48 || valor[i] > 57)
				{
					throw new Exception("valor invalido");
				}
				numero += (valor[i] - 48) * Math.Pow(10, j);
			}
			return numero;
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um numero inteiro:");
			string valorEmString = Console.ReadLine();
			double valorEmInt = ConverteParaIntEsperto(valorEmString);
			Console.WriteLine("O numero inserido foi " + valorEmInt);
			Console.Write("Pressione 'enter' para sair");
			Console.ReadLine();
		}
	}
}