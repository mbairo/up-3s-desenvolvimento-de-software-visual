class VerificaNumeros
{
    public void mostraResultado(double num1, double num2) 
    { 
            if (num1 > num2)
            {
                Console.WriteLine("Maior número digitado: " + num1);
                Console.WriteLine("Menor número digitado: " + num2);
            }
            else
            {
                Console.WriteLine("Maior número digitado: " + num2);
                Console.WriteLine("Menor número digitado: " + num1);
            }
    }

}