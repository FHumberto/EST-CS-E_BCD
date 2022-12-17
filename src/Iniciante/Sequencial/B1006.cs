using System.Globalization;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1006 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1006 - Média 2\n");

            double[] nota = new double[3];

            for (int i = 0; i < nota.Length; i++)
            {
                nota[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (nota[0] * 2 + nota[1] * 3 + nota[2] * 5) / 10.0;

            Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}