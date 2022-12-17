using System.Globalization;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1009 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1009 - Salário com Bônus\n");

            _ = Console.ReadLine();
            double[] valor = new double[2];

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double total = valor[0] + (valor[1] * 0.15);

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}