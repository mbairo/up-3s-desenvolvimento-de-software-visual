class Cadastrar
{
    public bool cadastro (string usuario, string senha)
        {
            string registro = usuario + ":" + senha;
            File.AppendAllText("cadastro.txt", registro);
            return true;
        }
}