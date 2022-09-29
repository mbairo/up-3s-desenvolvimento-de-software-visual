using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Trabalho
{
	class Usuario
	{
		long id;
		string nome;
		string email;
		string hash;
		
		//cria usuario a partir de email e senha (usado na Main)
		public Usuario(string n, string e, string password)
		{
			id = DateTime.Now.Ticks; //aqui estou usando o tempo atual (em milisegundos) como id do usuario
			nome = n;
			email = e;
			hash = GerarHash(password);
		}
		
		//cria usuario a partir de dados salvos na base (esse construtor eh usado apenas pela classe BaseUsuarios)
		public Usuario(long i, string n, string e, string h)
		{
			id = i;
			nome = n;
			email = e;
			hash = h;
		}
		
		string GerarHash(string password)
		{
			//converte password de string ("array de chars") para array de bytes
			byte[] passwordEmBytes = System.Text.Encoding.UTF8.GetBytes(password);
			//gera a hash correspondente usando o sha256
			byte[] hashEmBytes = SHA256.Create().ComputeHash(passwordEmBytes);
			//converte array de bytes de novo para string
			string hashEmString = BitConverter.ToString(hashEmBytes);
			//remove os hifens
			hashEmString = hashEmString.Replace("-", String.Empty);
			//retorna hash
			return hashEmString;
		}
		
		public long GetId()
		{
			return id;
		}
		
		public string GetNome()
		{
			return nome;
		}
		
		public string GetEmail()
		{
			return email;
		}
		
		public string GetHash()
		{
			return hash;
		}
		
		public void SetNome(string n)
		{
			nome = n;
		}
		
		public void SetEmail(string e)
		{
			email = e;
		}
		
		public string Serializar()
		{
			return id + "," + nome + "," + email + "," + hash;
		}
	}
	
	class BaseUsuarios
	{
		string filename;
		List<Usuario> usuarios;
		
		public BaseUsuarios(string f = "usuarios.txt")
		{
			filename = f;
			usuarios = new List<Usuario>();
			Carregar();
		}
		
		public void Carregar()
		{
			if(!File.Exists(filename))
			{
			  File.CreateText(filename);
			}
			string input = File.ReadAllText(filename);
			string[] linhas = input.Split("\n");
			foreach(var linha in linhas)
			{
				if(linha.Length > 0)
				{
					string[] valores = linha.Split(",");
					Usuario usuario = new Usuario(long.Parse(valores[0]), valores[1], valores[2], valores[3]);
					usuarios.Add(usuario);
				}
			}
		}
		
		public string Serializar()
		{
			string output = "";
			foreach(var usuario in usuarios)
			{
				output += usuario.Serializar() + "\n";
			}
			return output;
		}
		
		public void Salvar()
		{
			string output = Serializar();
			File.WriteAllText(filename, output);
		}
				
		public void Limpar()
		{
			usuarios.Clear();
		}
		
		public void AdicionarUsuario(Usuario u)
		{
			foreach(var usuario in usuarios)
			{
				//lanca erro caso usuario ja esteja na lista ou email ja esteja em uso
				if(usuario.GetId() == u.GetId())
				{
					throw new Exception($"usuario '{u.GetId()}' ja esta na lista");
				}
				else if(usuario.GetEmail() == u.GetEmail())
				{
					throw new Exception($"email '{u.GetEmail()}' ja esta sendo utilizado");
				}
			}
			usuarios.Add(u);
		}
		
		public void AtualizarUsuario(Usuario u)
		{
			foreach(var usuario in usuarios)
			{
				if(usuario.GetId() == u.GetId())
				{
					usuarios.Remove(usuario);
					usuarios.Add(u);
					return;
				}
			}
			//caso nao encontre o usuario, lanca erro
			throw new Exception($"usuario '{u.GetEmail()}' nao foi encontrado na base");
		}
				
		public void RemoverUsuario(Usuario u)
		{
			foreach(var usuario in usuarios)
			{
				if(usuario.GetId() == u.GetId())
				{
					usuarios.Remove(usuario);
					return;
				}
			}
		}
		
		//retorna usuario que possui email indicado
		public Usuario BuscarPorEmail(string email)
		{
			foreach(var usuario in usuarios)
			{
				if(usuario.GetEmail() == email)
				{
					return usuario;
				}
			}
			//caso nao encontre, lanca erro
			throw new Exception($"usuario '{email}' nao foi encontrado na base");
		}
	}
}