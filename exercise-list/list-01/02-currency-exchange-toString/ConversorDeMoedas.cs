class ConversorDeMoedas {
    public double real;
    public double dolar;
    public double euro;
    public double pesoArgentino;

    public void ConversorDeMoedas (double real) {
        this.real = real;
    }
    
    public void conversor () {
        this.dolar = real / 5.17;
        this.euro = real / 6.14;
        this.pesoArgentino = real / 0.05;
    }

    public override string ToString()
    {
        return "\n--- Lista das conversões --- \nDolar: " + dolar + "\nEuro: " + euro + "\nPeso Argentino: " + pesoArgentino;
    }
    
}
