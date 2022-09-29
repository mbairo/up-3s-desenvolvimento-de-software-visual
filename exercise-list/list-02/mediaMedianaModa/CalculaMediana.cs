class CalculaMediana
{
    public void mostraMediana(double []numeros) 
    {
        Array.Sort(numeros);
        int mediana = Convert.ToInt16(numeros.Length / 2);
        if (numeros.Length % 2 == 0)
        {
           double medianaDecimal = (numeros[mediana] + numeros[mediana -1 ]) / 2;
           Console.WriteLine("Mediana: " + medianaDecimal);
        } else {
            Console.WriteLine("Mediana: " + numeros[mediana]);
        }
    }
}