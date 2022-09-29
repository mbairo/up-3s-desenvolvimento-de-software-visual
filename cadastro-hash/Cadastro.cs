class Cadastro
{
    public bool cadastrar (string username, string password)
        {
            string linha = username + "=" + password;

            File.AppendAllText("user.txt", linha);
            return true;
        }
}