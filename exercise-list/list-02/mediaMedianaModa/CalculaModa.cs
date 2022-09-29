class CalculaModa
{
    public void mostraModa(double []numeros) 
    { 
        int [] repetiu = new int [numeros.Length];
        int qdtRepeticoes = 0;
        int moda = 0;
    
        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = 1; j < numeros.Length; j++)
            {
                 if (numeros[i] == numeros[j]) {
                     repetiu [i] += 1;
                 }
                 if (repetiu[i] > qdtRepeticoes){
                    qdtRepeticoes = repetiu[i];
                    moda = i;
                 }
            }
        }
        if (qdtRepeticoes > 0)
        {
            Console.WriteLine("Moda: " + numeros[moda] + " (Repetiu " + repetiu[qdtRepeticoes] + " veze(s))");
        } else 
        {
            Console.WriteLine("Não houve números repetidos, portanto nenhuma Moda");            
        }
    }
}
