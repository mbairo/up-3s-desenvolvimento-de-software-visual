class CalculaMedia
{
    public void mostraMedia(double []numeros) 
    { 
        double media = 0;
        foreach (double item in numeros)
        {
            media += item;
        }
        Console.WriteLine("Média: " + media / numeros.Length);
    }
}