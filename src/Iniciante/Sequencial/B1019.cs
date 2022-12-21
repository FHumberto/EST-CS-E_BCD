using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1019 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1019 - Conversão de Tempo\n");

            int tempo = int.Parse(Console.ReadLine());

            int horas = tempo / 3600;
            int minutos = (tempo / 60) % 60;
            int segundos = tempo % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}