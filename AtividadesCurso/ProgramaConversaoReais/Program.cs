using System.Net.Http.Headers;

namespace ProgramaConversaoReais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                while (true)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("-Programa de conversão da moeda real para outras moedas-");
                    Console.WriteLine("--------------------------------------------------------");

                    Console.WriteLine("Digite o numero da opção desejada e aperte 'enter'\n");
                    Console.WriteLine("(1) Converter Real Para dolar\n");
                    Console.WriteLine("(2) Converter Real Para Euro\n");
                    Console.WriteLine("(3) Converter Real Para Pesos Argentinos\n");
                    Console.WriteLine("(4) Converter Real Para Baht Tailandês\n");
                    Console.WriteLine("(6) fechar Programa\n");

                    char opcao = char.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (opcao)
                    {
                        case '1':
                            realParaDolar();
                            break;
                        case '2':
                            realParaEuro();
                            break;
                        case '3':
                            realParaPesosArgentinos();
                            break;
                        case '4':
                            realParaBahtTailandes();
                            break;
                    }
                    if (opcao == '6')
                    {
                        break;
                    }
                }

            }
            void realParaDolar()
            {
                Console.WriteLine("Quantos reais você quer converter para Dolar?(Exemplo: 10,99)\n");
                decimal quantidadeDeReaisParaDolar = decimal.Parse(Console.ReadLine());
                decimal quantidadeDolares = quantidadeDeReaisParaDolar * (decimal)0.20;
                Console.WriteLine($"\nR${quantidadeDeReaisParaDolar} em Dolares é ${quantidadeDolares}\n");
                Console.WriteLine("Aperte qualquer tecla para retornar ao menu inicial");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            void realParaEuro()
            {
                Console.WriteLine("Quantos reais você quer converter para Euro?(Exemplo: 10,99)\n");
                decimal quantidadeDeReaisParaEuro = decimal.Parse(Console.ReadLine());
                decimal quantidadeEuros = quantidadeDeReaisParaEuro * (decimal)0.18;
                Console.WriteLine($"\nR${quantidadeDeReaisParaEuro} em Euros é €{quantidadeEuros}\n");
                Console.WriteLine("Aperte qualquer tecla para retornar ao menu inicial");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            void realParaPesosArgentinos()
            {
                Console.WriteLine("Quantos reais você quer converter para Pesos Argentinos?(Exemplo: 10,99)\n");
                decimal quantidadeDeReaisParaPesosArgentinos = decimal.Parse(Console.ReadLine());
                decimal quantidadePesosArgentinos = quantidadeDeReaisParaPesosArgentinos * (decimal)35.78;
                Console.WriteLine($"\nR${quantidadeDeReaisParaPesosArgentinos} em Pesos Argentinos é ${quantidadePesosArgentinos}\n");
                Console.WriteLine("Aperte qualquer tecla para retornar ao menu inicial");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            void realParaBahtTailandes()
            {
                Console.WriteLine("Quantos reais você quer converter para Bath Tailandês?(Exemplo: 10,99)\n");
                decimal quantidadeDeReaisParaBath = decimal.Parse(Console.ReadLine());
                decimal quantidadeBath = quantidadeDeReaisParaBath * (decimal)6.48;
                Console.WriteLine($"\nR${quantidadeDeReaisParaBath} em Dolares é ฿{quantidadeBath}\n");
                Console.WriteLine("Aperte qualquer tecla para retornar ao menu inicial");
                Console.ReadKey();
                Console.Clear();
                return;

            }
        }
    }
}