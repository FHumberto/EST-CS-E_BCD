using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1018 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1018 - Cédulas\n");

            int valor = int.Parse(Console.ReadLine());
            int i = 0;
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine(valor);

            do
            {
                Console.WriteLine($"{valor / notas[i]} nota(s) de R$ {notas[i]},00");
                if (valor >= notas[i])
                {
                    valor -= notas[i] * (valor / notas[i]);
                }
            } while (notas[i++] != 1);
        }
    }
}