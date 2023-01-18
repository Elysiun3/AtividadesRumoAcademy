namespace Calcular_consumo_energetico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("---Calculadora de consumo energetico---");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("Qual o preço do Kilo Watt de energia da sua rede eletrica.\n");
                decimal precoKW = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Qual a potência em Watts do dispositivo que vc quer calcular.\n");
                decimal potenciaWatts = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Quantas horas esse dispositivo fica ligado por dia?\n");
                decimal horasLigadoDia = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Quantos dias o dispositivo fica ligado por mês.\n");
                decimal diasLigados = decimal.Parse(Console.ReadLine());
                decimal KWh = ((potenciaWatts / 1000) * horasLigadoDia);
                decimal valorKWh = KWh * precoKW;
                decimal consumoMensal = valorKWh * diasLigados;


                Console.WriteLine($"Esse dispositivo gera uma despesa mensal de R${consumoMensal}\n");
                Console.WriteLine("aperte qualquer tecla para voltar do inicio\n");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
        }
    }
}