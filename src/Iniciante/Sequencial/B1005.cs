using System.Globalization;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1005 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1005 - Média 1\n");

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a * 3.5 + b * 7.5) / 11;

            Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}