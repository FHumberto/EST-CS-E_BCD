using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1014 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1014 - Consumo\n");

            int distancia = int.Parse(Console.ReadLine());
            double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = distancia / combustivel;

            Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}