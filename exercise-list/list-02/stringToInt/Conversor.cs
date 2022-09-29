public class Conversor 
{
    public void int (string numString)
    {
        int numInt = 0;
        int qdtDigitos = numString.Length;
        for (indice = 0; j = numString.Length - 1; indice < numString.Length; indice++, j--)
        {
            numInt += numString[indice] * (Math.Pow(10, j));
        }
    }
}