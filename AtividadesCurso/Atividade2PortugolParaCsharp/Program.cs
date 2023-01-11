namespace Atividade2PortugolParaCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a distancia maxima que meu veiculo pode percorrer");

            Console.WriteLine("Quantos litros de combustivel havia em seu tanque no momento da partida?");
            string? quantosLitros = Console.ReadLine();
            int litrosCombustivel = Convert.ToInt32(quantosLitros);

            Console.WriteLine("Qual o consumo medio do seu veiculo em Km por litro?");
            string? consumo = Console.ReadLine();
            int consumoMedio = Convert.ToInt32(consumo);

            int distanciaMaxima = consumoMedio * litrosCombustivel;
            Console.WriteLine($"seu veiculo pode percorrer: {distanciaMaxima} km");
        }
    }
}