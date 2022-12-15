﻿using System.Globalization;

namespace E_BCD.Iniciante.Sequencial
{
    internal static class B1002
    {
        public static void PMain()
        {
            Console.WriteLine("\nProblema 1002 - Área do Círculo\n");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}