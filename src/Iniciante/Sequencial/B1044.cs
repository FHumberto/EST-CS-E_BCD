
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1044 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1044 - Múltiplos\n");

            int[] numero = new int[2];
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = int.Parse(linha[i]);
            }

            if (numero[0] % numero[1] == 0 || numero[1] % numero[0] == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}