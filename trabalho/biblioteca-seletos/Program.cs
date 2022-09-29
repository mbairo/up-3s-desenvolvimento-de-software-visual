using System;

namespace BibliotecaSeletos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastrar cadastrar = new Cadastrar();
            int option = 100;
            do
            {
                Console.WriteLine("\n\n#########################################");
                Console.WriteLine("--- Bem vindo à Biblioteca Seletos ---\n");
                Console.WriteLine("1 - Logar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                option = int.Parse(Console.ReadLine());
            
                switch (option)
                {
                    case 1:
                    Console.WriteLine("\n***Opção 1 está em construção. Ou ao menos deveria estar... \nVolte mais tarde!");
                    break;
                    case 2:
                        Console.Write("Nome do usuario: ");
                        string usuario = Console.ReadLine();
                        
                        Console.Write("Senha: ");
                        string senha = Console.ReadLine();

                        Console.Write("Confirme a senha: ");
                        string confirme = Console.ReadLine();
                        
                        if (senha != confirme)
                        {
                            Console.WriteLine("\n************************\nATENÇÃO: Senhas não coincidem! \nCadastro cancelado!\n************************\n");
                        }
                        else
                        {
                            if (cadastrar.cadastro(usuario, senha))
                            {
                                Console.WriteLine("\n### Cadastro efetuado ###");
                            } else
                            {
                                Console.WriteLine("\nATENÇÃO: Nome já cadastrado - Não foi possivel cadastrar!!!");
                            }
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nVocê saiu!\n\n");
                        break;
                    default:
                        Console.WriteLine("\n*Opção invalida. Tente novamente!");
                        break;
                }    

            } while (option != 0);



        }
    }
}