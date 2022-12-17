using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1004 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1004 - Produto Simples\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int produto = a * b;

            Console.WriteLine($"PROD = {produto}");
        }
    }
}