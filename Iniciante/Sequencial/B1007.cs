using E_BCD.Template;

namespace E_BCD.Iniciante.Sequencial
{
    internal class B1007 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1007 - Diferença\n");

            int[] valor = new int[4];

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = int.Parse(Console.ReadLine());
            }

            int diferenca = valor[0] * valor[1] - valor[2] * valor[3];

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}