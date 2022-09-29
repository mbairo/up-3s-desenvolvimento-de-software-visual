using System;
class Conversor {
    public void mostrarConversao(double real) 
    {        
        Console.WriteLine(
        "R$" + real + " Reais equivale a: " +
        "\nDolar: " + real / 5.17 + 
        "\nEuro: " + real / 6.14 + 
        "\nPeso Argentino: " + real / 0.05);
    }
}
