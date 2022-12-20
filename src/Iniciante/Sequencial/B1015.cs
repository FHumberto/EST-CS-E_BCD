using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1015 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1015 - Distância Entre Dois Pontos\n");

            float[] x = new float[2];
            float[] y = new float[2];

            for (int i = 0; i <= 1; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                x[i] = float.Parse(linha[0], CultureInfo.InvariantCulture);
                y[i] = float.Parse(linha[1], CultureInfo.InvariantCulture);
            }

            double distancia = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}