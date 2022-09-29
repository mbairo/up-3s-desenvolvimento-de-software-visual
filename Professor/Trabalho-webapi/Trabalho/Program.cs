using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

//essa eh uma "minimal webapi" (requer SDK .NET 6.0 ou superior)
//criar projeto com o comando "dotnet new webapi -minimal -o NomeDoProjeto"
//para testar esse codigo, substitua o Program.cs do projeto criado por esse
//executar o projeto com o comando "dotnet run" ou "dotnet watch run" (esse atualiza o servico em tempo real se o codigo for alterado)
//verificar nas informacoes impressas em quais enderecos a API esta recebendo os chamados

namespace Trabalho
{
	class Program
	{
		//exemplo de funcoes estatica que pode ser mapeadas em algum endpoint da api
		static string welcome()
		{
			return "hello world";
		}
						
		//exemplo da previsao do tempo implementada como uma funcao estatica
		static string getWeather()
		{
			string[] summaries = {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};
			
			var date = DateTime.Now;
			var celsius = Random.Shared.Next(-20, 55);
			var fahrenheit = 32 + (int)(celsius / 0.5556);
			var index = Random.Shared.Next(0, summaries.Length-1);
			
			return String.Format("{{date:'{0}',celsius:{1},fahrenheit:{2},summary:'{3}'}}", date.ToString(), celsius, fahrenheit, summaries[index]);
		}
		
		static void Main(string[] args)
		{
			//cria o criador (builder) de aplicacoes
			var builder = WebApplication.CreateBuilder(args);
			
			//cria a aplicacao usando o builder
			var app = builder.Build();
			
			//instancia nossa base de usuarios
			BaseUsuarios baseUsuarios = new BaseUsuarios("usuarios.txt");
			
			//mapeia a raiz da nossa url para a funcao "welcome" via metodo GET (observe que a propria funcao esta sendo enviada como argumento, e nao o retorno dela)
			app.MapGet("/", welcome);
			
			//mapeia a funcao de previsao do tempo para o path "weather" via metodo GET
			app.MapGet("/weather", getWeather);
			
			//cria uma funcao lambda que retorna uma impressao da base
			var getUsuarios = () => {
				return baseUsuarios.Serializar();
			};
			
			//mapeia a funcao acima para para o path "usuarios" via metodo GET
			app.MapGet("/usuarios", getUsuarios);
			
			//cria uma funcao lambda que retorna uma impressao de um usuario
			var getUsuario = (string email) => {
				return baseUsuarios.BuscarPorEmail(email).Serializar();
			};
			
			//mapeia a funcao acima para o path "usuario/{email}", onde {email} eh o valor que sera enviado para o argumento "email" da funcao "getUsuario"
			app.MapGet("/usuarios/{email}", getUsuario);
			
			//cria uma funcao lambda que recebe um record (declarado no final desse codigo), usa esse record para criar um usuario e insere esse usuario na base
			var postUsuario = (ChavesUsuario u) => {
				var usuario = new Usuario(u.nome, u.email, u.password);
				baseUsuarios.AdicionarUsuario(usuario);
				return "usuario adicionado";
			};
			
			//mapeia a funcao acima para o path "cadastrar" usando o metodo POST (o paylod do POST deve ser um JSON que sera mapeado para o record)
			app.MapPost("/cadastrar", postUsuario);
			
			//inicia a aplicacao
			app.Run();
		}
		
		//esse record possui o nome das chaves do JSON que o POST deve enviar e que a funcao chamada pelo POST quer receber
		record ChavesUsuario(string nome, string email, string password);
	}
}