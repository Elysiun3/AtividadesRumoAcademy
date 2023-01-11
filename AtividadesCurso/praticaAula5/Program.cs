namespace praticaAula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular consumo de combustivel do carro");

            Console.WriteLine("Quantos litros de combustivel havia em seu tanque no momento da partida?");
            string? quantosLitros = Console.ReadLine();
            int litrosCombustivel = Convert.ToInt32(quantosLitros);

            Console.WriteLine("Quantos Quilômetros você percorreu com esse combustivel?");
            string? quantosQuilometros = Console.ReadLine();
            int kmPercorrido = Convert.ToInt32(quantosQuilometros);

            int consumoMedio = kmPercorrido / litrosCombustivel;
            Console.WriteLine($"o seu consumo medio é de {consumoMedio} km/L");
        }
    }
}