namespace ClassificadorDeNadadores
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-Programa de classificação dos nadadores-");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("Quantos Anos tem esse(a) Nadador(a)? (Ex: 10)\n");

                    int anos = Convert.ToInt32(Console.ReadLine());
                    if (anos < 5)
                    {
                        Console.WriteLine("Não é possivel classificar crianças menores que 5 anos\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (anos > 25)
                    {
                        Console.WriteLine("Não é possivel classificar pessoas maiores de 25 anos\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (5 <= anos && anos <= 7)
                    {
                        Console.WriteLine("Esse(a) Nadador(a) está na classificação (Infantil A)\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (8 <= anos && anos <= 10)
                    {
                        Console.WriteLine("Esse(a) Nadador(a) está na classificação (Infantil B)\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (11 <= anos && anos <= 13)
                    {
                        Console.WriteLine("Esse(a) Nadador(a) está na classificação (Juvenil A)\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (14 <= anos && anos <= 17)
                    {
                        Console.WriteLine("Esse(a) Nadador(a) está na classificação (Juvenil B)\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (18 <= anos && anos <= 25)
                    {
                        Console.WriteLine("Esse(a) Nadador(a) está na classificação (Senior)\n");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                
            }
        }
    }
}