using System;

namespace valorSalarioDiario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("---Programa para calcular salario diario---");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("Informe seu Nivel de valor da hora de trabalho\n");
                Console.WriteLine("Digite o numero da opção desejada e aperte 'enter'\n");
                Console.WriteLine("(1) Nivel 1 = R$12,00\n");
                Console.WriteLine("(2) Nivel 2 = R$18,00\n");
                Console.WriteLine("(3) Nivel 3 = R$25,00\n");
                Console.WriteLine("(5) Fechar Programa");

                char nivel = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (nivel)
                {
                    case '1':
                        nivel1();
                        break;
                    case '2':
                        nivel2();
                        break;
                    case '3':
                        nivel3();
                        break;
                }
                if (nivel == '5')
                {
                    break;
                }
                void nivel1()
                {
                    Console.WriteLine("Quantas horas você trabalha por dia?");
                    decimal horas = decimal.Parse(Console.ReadLine());
                    decimal salarioDiario = horas * 12;
                    Console.WriteLine($" o seu salario será R${salarioDiario} por dia.\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.ReadKey();
                    Console.Clear();
                    return;

                }
                void nivel2()
                {
                    Console.WriteLine("Quantas horas você trabalha por dia?");
                    decimal horas = decimal.Parse(Console.ReadLine());
                    decimal salarioDiario = horas * 18;
                    Console.WriteLine($" o seu salario será R${salarioDiario} por dia.\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                void nivel3()
                {
                    Console.WriteLine("Quantas horas você trabalha por dia?");
                    decimal horas = decimal.Parse(Console.ReadLine());
                    decimal salarioDiario = horas * 25;
                    Console.WriteLine($" o seu salario será R${salarioDiario} por dia.\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
        }
    }
}