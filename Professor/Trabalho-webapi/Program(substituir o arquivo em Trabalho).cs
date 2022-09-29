using System;

namespace Trabalho
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var baseUsuarios = new BaseUsuarios("usuarios.txt");
				
				Console.WriteLine("Bem vind@!");
				
				bool sair = false;
				while(!sair)
				{
					Console.WriteLine("Digite 1 para listar os usuarios");
					Console.WriteLine("Digite 2 para cadastrar um usuario");
					Console.WriteLine("Digite 3 para atualizar um usuario");
					Console.WriteLine("Digite 4 para remover um usuario");
					Console.WriteLine("Digite 5 para sair");
					
					int opcao = 0;
					
					try
					{
						opcao = int.Parse(Console.ReadLine());
					}
					catch(Exception erro)
					{
					}
					
					switch(opcao)
					{
						case 1:
							
							Console.WriteLine(baseUsuarios.Serializar());
							break;
						
						case 2:
							
							{
								Console.WriteLine("Insira o nome do usuario");
								var username = Console.ReadLine();
								Console.WriteLine("Insira o email do usuario");
								var email = Console.ReadLine();
								Console.WriteLine("Insira uma senha");
								var password = Console.ReadLine();
								Console.WriteLine("Confirme a senha");
								var confirmacao = Console.ReadLine();
								if(password != confirmacao)
								{
									Console.WriteLine("Senha nao confere");
									break;
								}
								else
								{
									var usuario = new Usuario(username, email, password);
									baseUsuarios.AdicionarUsuario(usuario);
								}
							}
							break;
						
						case 3:
							
							//TODO atualizar usuario
							Console.WriteLine("Desculpe, esta opcao ainda nao foi implementada =/");
							break;
						
						case 4:
							
							{
								Console.WriteLine("Insira o email do usuario que deseja remover");
								var email = Console.ReadLine();
								try
								{
									var usuario = baseUsuarios.BuscarPorEmail(email);
									baseUsuarios.RemoverUsuario(usuario);
								}
								catch(Exception erro)
								{
									Console.WriteLine("Nao foi possivel remover o usuario " + email);
								}
							}
							break;
						
						case 5:
							sair = true;
							break;
							
						default:
							Console.WriteLine("Opcao invalida! Tente novamente...");
							break;
					}
					
					Console.WriteLine();
				}
				
				baseUsuarios.Salvar();
			}
			catch(Exception erro)
			{
				Console.WriteLine(erro.Message);
			}
		}
	}
}