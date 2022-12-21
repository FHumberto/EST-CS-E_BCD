using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1020 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1020 - Idade em Dias\n");

            int valor = int.Parse(Console.ReadLine());

            int ano = valor / 365;
            int mes = (valor % 365) / 30;
            int dia = (valor % 365) % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}