using System.Globalization;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1012 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1012 - Área\n");

            float[] valor = new float[3];
            string[] linha = Console.ReadLine().Split(' ');
            valor[0] = float.Parse(linha[0], CultureInfo.InvariantCulture);
            valor[1] = float.Parse(linha[1], CultureInfo.InvariantCulture);
            valor[2] = float.Parse(linha[2], CultureInfo.InvariantCulture);

            double triangulo = (valor[0] * valor[2]) / 2;
            double circulo = 3.14159 * Math.Pow(valor[2], 2);
            double trapezio = ((valor[0] + valor[1]) * valor[2]) / 2;
            double quadrado = Math.Pow(valor[1], 2);
            double retangulo = valor[0] * valor[1];

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}