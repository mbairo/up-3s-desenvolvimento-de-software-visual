// aula04
using System.Security.Cryptography;
using System.IO;
using CadastroHash;

namespace CadastroHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario a = new Usuario("Jango", "batatinha123");
            Usuario b = new Usuario("lewy", "pokemon38");
            Usuario c = new Usuario("ana", "asdfasd");
            //Console.WriteLine($"{u.GetUsername()}, {u.GetHash()}");

            Console.WriteLine(a.Serialize());
            Console.WriteLine(b.Serialize());
            Console.WriteLine(c.Serialize());
            
            UserBase mybase = new UserBase ("userbase.txt");
            mybase.AddUser(a);
            mybase.AddUser(b);
            mybase.AddUser(c);
            mybase.Save();
            //Console.WriteLine(q.Serialize());
        }        
    }
    //teste
}
