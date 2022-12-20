using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1017 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1016 - Gasto de Combustível\n");

            int tempoGasto = int.Parse(Console.ReadLine());
            float velocidadeMedia = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = (tempoGasto * velocidadeMedia) / 12;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}