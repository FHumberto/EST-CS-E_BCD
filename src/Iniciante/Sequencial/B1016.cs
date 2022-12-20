using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1016 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1016 - Distância\n");

            int distancia = int.Parse(Console.ReadLine());
            int tempo = distancia * 2;
            Console.WriteLine($"{tempo} minutos");
        }
    }
}