using System.Globalization;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1011 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1011 - Esfera\n");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3);
            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}