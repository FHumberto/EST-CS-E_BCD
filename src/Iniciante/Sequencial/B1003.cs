using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1003 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1003 - Soma Simples\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}