using System.Globalization;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1010 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1010 - Cálculo Simples\n");

            int[] quantidade = new int[2];
            float[] valor = new float[2];
            float valorAPagar = 0;

            for (int i = 0; i <= 1; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                _ = linha[0];
                quantidade[i] = int.Parse(linha[1]);
                valor[i] = float.Parse(linha[2], CultureInfo.InvariantCulture);
                valorAPagar += quantidade[i] * valor[i];
            }

            Console.WriteLine($"VALOR A PAGAR: R$ {valorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}