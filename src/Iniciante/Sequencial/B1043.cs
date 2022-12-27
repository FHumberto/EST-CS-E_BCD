using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1043 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1043 - Triângulo\n");

            double[] ponto = new double[3];
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < linha.Length; i++)
            {
                ponto[i] = double.Parse(linha[i], CultureInfo.InvariantCulture);
            }

            double perimetro = ponto[0] + ponto[1] + ponto[2];
            double area = ((ponto[0] + ponto[1]) * ponto[2]) / 2;

            Array.Sort(ponto);

            if (ponto[2] < ponto[0] + ponto[1])
            {
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}