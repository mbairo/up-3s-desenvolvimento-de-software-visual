// aula04
using System.Security.Cryptography;
using System.IO;
namespace CadastroHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            bool sair = false;
            while (!sair) // Enquanto sair for falso (contendo "false")
            {
                Console.WriteLine("\n--- Bem Vindo à área de Cadastro/Login --- ");

                Console.WriteLine("1 - Logar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite a opção desejada: ");

                int opcao = 0;
                try 
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception erro)
                {
                    //Console.WriteLine("Erro");
                    // nada
                }

                switch (opcao)
                {
                    case 1:
                        // logar... Criar função
                        Console.WriteLine("\n***Opção 1 está em construção. Ou ao menos deveria estar. Volte mais tarde...");
                        break;
                    case 2:
                        Console.Write("Digite um nome de usuario: ");
                        string username = Console.ReadLine();
                        
                        Console.Write("Digite uma senha: ");
                        string password = Console.ReadLine();

                        Console.Write("Confirme a senha: ");
                        string confirm = Console.ReadLine();
                        
                        if (password != confirm)
                        {
                            Console.WriteLine("\n************************\nATENÇÃO: Senhas não coincidem! \nCadastro cancelado!\n************************\n");
                        }
                        else
                        {
                            if (cadastro.cadastrar(username, password))
                            {
                                Console.WriteLine("\n### Cadastro efetuado ###");
                            } else
                            {
                                Console.WriteLine("\nATENÇÃO: Nome já cadastrado - Não foi possivel cadastrar!!!");
                            }
                        }
                        break;
                    case 3:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("\n*Opção invalida. Tente novamente!");
                        break;
                }                
            }
            //HashAlgorithm sha = new SHA256.Create();            
        }        
    }
}