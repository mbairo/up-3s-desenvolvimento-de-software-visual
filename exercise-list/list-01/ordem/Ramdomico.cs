class Ramdomico
{
    public void numerosAletorios (){

            Random ramdom = new Random();

            int [] numeros = new int [5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros [i] = ramdom.Next(1000);
            }

            Console.WriteLine("Números Aleatórios ");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            numerosOrdenados(numeros);
    }

    public void numerosOrdenados (int [] numeros) {

            Array.Sort(numeros);

            Console.WriteLine("--- Números em ordem ---");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
    }
}