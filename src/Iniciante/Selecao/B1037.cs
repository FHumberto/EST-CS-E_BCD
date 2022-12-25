﻿using System.Globalization;
using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Selecao
{
    internal class B1037 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1037 - Intervalo\n");

            float ponto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ponto >= 0 && ponto <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (ponto > 25.0000 && ponto <= 50.0000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (ponto > 50.0000 && ponto <= 75.0000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (ponto > 75.0000 && ponto <= 100.0000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}