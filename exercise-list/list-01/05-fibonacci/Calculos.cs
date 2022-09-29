class Calculos
{
    public void resultado(int numInformado)
    {   
        int antepenultimo = 0;
        int penultimo = 1;
        int atual = 1;
        int x = 0;
        if (numInformado == 0)
        {
            Console.Write("numInformado");
            } else
            {
                Console.WriteLine(antepenultimo);
                Console.WriteLine(penultimo);   
                while (x <= numInformado) {
                    x = atual + penultimo;
                    Console.WriteLine(atual);
                    antepenultimo = penultimo;
                    penultimo = atual;
                    atual = penultimo + antepenultimo; 
            }
            }
    }
}

