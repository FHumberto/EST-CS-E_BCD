using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1041 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1041 - Coordenadas de um Ponto\n");

            float[] ponto = new float[2];
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < linha.Length; i++)
            {
                ponto[i] = float.Parse(linha[i], CultureInfo.InvariantCulture);
            }

            if (ponto[0] == 0 && ponto[1] != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (ponto[0] != 0 && ponto[1] == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (ponto[0] > 0 && ponto[1] > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (ponto[0] < 0 && ponto[1] > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (ponto[0] < 0 && ponto[1] < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (ponto[0] > 0 && ponto[1] < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}