class VerificaFaixaEtaria
{
    public  void mostraResultado(double idade)
    {
        if (idade < 1 ) {
                Console.WriteLine("Favor informar uma idade válida!");
            } else if (idade <= 13) {
                Console.WriteLine("Criança");
            } else if (idade > 13 && idade < 18) {
                Console.WriteLine("Adolescente");
            } else if (idade > 18 && idade < 60) {
                Console.WriteLine("Adulto");
            } else {
                Console.WriteLine("Idoso");
            } 
    }
}