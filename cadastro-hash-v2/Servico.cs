
using System.Collections.Generic;
using System.IO;
using System;

namespace CadastroHash
{
  class Usuario
  {
    static int UID = 0;
    int id;
    string username;
    string hash;

    public Usuario (String u, string p)
    {
        id = getUID();
        SetUsername(u);
        ApplyHash(p);
    }

    static int getUID(){
      UID++;
      return UID;
    }
    
    void ApplyHash(string password)
    {
      //TODO aplicar a hash
      hash = password;
    }  

    public string GetUsername()
    {
      return username;
    }

    // public string GetHash()
    // {
    //   return hash;
    // }

    public void SetUsername(string u)
    {
      username = u;
    }

    public string Serialize(){
      return id + "," + username + "," + hash;
    }
  }

  class UserBase
  {

    string filename;
    List<Usuario> usuarios;

    public UserBase(string f)
    {
      filename = f;
      usuarios = new List<Usuario>();
      LoadUsers();
    }

    void LoadUsers()
    {
      // TODO carregar usuarios do arquivo
    }

    public void AddUser(Usuario u)
    {
      usuarios.Add(u);
    }

    public void Save()
    {
      string output = "";

      foreach (Usuario u in usuarios)
      {
        output += u.Serialize() + "\n";
      }
      File.WriteAllText(filename, output);
    }

  }
}