namespace ExemploDaAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!!!!");


            var matrizNumeros = new int[1, 2];

            matrizNumeros[0, 0] = 1;
            matrizNumeros[0, 1] = 4;
            matrizNumeros[0, 2] = 67;

            matrizNumeros[1, 0] = 1;
            matrizNumeros[1, 1] = 1;
            matrizNumeros[1, 2] = 1;
        }
    }
}