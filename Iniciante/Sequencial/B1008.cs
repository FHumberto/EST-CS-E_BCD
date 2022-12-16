using System.Globalization;

using E_BCD.Template;

namespace E_BCD.Iniciante.Sequencial
{
    internal class B1008 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1008 - Salário\n");

            int codigo = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {codigo}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}