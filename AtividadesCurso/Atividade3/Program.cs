using System.Drawing;

namespace Atividade3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("###-------------------------------------------###");
            Console.WriteLine("###Gerar Relatorio de pagamento do funcionario###");
            Console.WriteLine("###-------------------------------------------###");

            Console.WriteLine("Qual o Nome do funcionario?");
            string? nomeFuncionario = Console.ReadLine();

            Console.WriteLine($"Qual o salario bruto mensal do {nomeFuncionario}?");
            string? salarioFixoMensal = Console.ReadLine();
            decimal salarioMensal = Convert.ToDecimal(salarioFixoMensal);


            Console.WriteLine($"O funcionario {nomeFuncionario} fez quantas vendas de TVs samsung esse mês?");
            string? VendasTvs = Console.ReadLine();
            int tvsVendidasMes = Convert.ToInt32(VendasTvs);

            Console.WriteLine($"Qual era o preço das Tvs vendidas por {nomeFuncionario}?");
            string? precoUnidadeTv = Console.ReadLine();
            decimal precoTvVendida = Convert.ToDecimal(precoUnidadeTv);
            decimal precoTvsTotal = tvsVendidasMes * precoTvVendida;

            double  comissaoTvs = (double)precoTvsTotal;
            double porcentagem = 15.0 / 100;

            double lucroTvs = porcentagem * comissaoTvs;
            decimal lucroFinalTvs = Convert.ToDecimal(lucroTvs);

            Console.WriteLine($"Quantos Smartphones samsung o funcionario {nomeFuncionario} vendeu esse mês?");
            string? smartphones = Console.ReadLine();
            int smartphonesVendidos = Convert.ToInt32(smartphones);

            Console.WriteLine($"Qual era o preço dos Smartphones vendidos por {nomeFuncionario}?");
            string? preçoSmartphones = Console.ReadLine();
            decimal precoSmartphonesVendidos = Convert.ToDecimal(preçoSmartphones);
            decimal precoSmartphoneTotal = precoSmartphonesVendidos * smartphonesVendidos;

            double comissaoSmartphones = (double)precoSmartphoneTotal;

            double lucroSmartphones = porcentagem * comissaoSmartphones;
            decimal lucroFinalSmartphones = Convert.ToDecimal(lucroSmartphones);

            decimal salarioEsseMes = salarioMensal + lucroFinalTvs + lucroFinalSmartphones;

            Console.WriteLine($"o salario do {nomeFuncionario} será R$ {salarioEsseMes} esse mês, sendo R$ {salarioMensal} de salario fixo e R$ {lucroFinalTvs + lucroFinalSmartphones} de comissão");


        }
    }
}