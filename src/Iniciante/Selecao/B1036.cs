using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Selecao
{
    internal class B1036 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1036 - Fórmula de Bhaskara\n");

            double[] ponto = new double[3];
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < ponto.Length; i++)
            {
                ponto[i] = double.Parse(linha[i], CultureInfo.InvariantCulture);
            }

            double delta = Math.Pow(ponto[1], 2) - 4 * ponto[0] * ponto[2];

            // o delta não pode ser igual ou menor que zero e o a não pode ser zero
            if (delta <= 0 || ponto[0] == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double[] raiz = new double[2];

                raiz[0] = (-ponto[1] + Math.Sqrt(delta)) / (2 * ponto[0]);
                raiz[1] = (-ponto[1] - Math.Sqrt(delta)) / (2 * ponto[0]);

                for (int i = 0; i < raiz.Length; i++)
                {
                    Console.WriteLine($"R{i + 1} = {raiz[i].ToString("F5", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}