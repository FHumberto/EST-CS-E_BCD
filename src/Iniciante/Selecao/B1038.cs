using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Selecao
{
    internal class B1038 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1038 - Lanche\n");

            int[] valor = new int[2];
            double total = 0;
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = int.Parse(linha[i]);
            }

            switch (valor[0])
            {
                case 1:
                    total = valor[1] * 4.00;
                    break;

                case 2:
                    total = valor[1] * 4.50;
                    break;

                case 3:
                    total = valor[1] * 5.00;
                    break;

                case 4:
                    total = valor[1] * 2.00;
                    break;

                case 5:
                    total = valor[1] * 1.50;
                    break;
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}