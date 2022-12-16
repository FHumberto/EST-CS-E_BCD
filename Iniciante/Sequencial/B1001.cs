using E_BCD.Template;

namespace E_BCD.Iniciante.Sequencial
{
    internal class B1001 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1001 - Extremamente Básico");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"X = {(a + b)}");
        }
    }
}