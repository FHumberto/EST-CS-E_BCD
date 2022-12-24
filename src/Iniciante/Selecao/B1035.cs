using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Selecao
{
    internal class B1035 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1035 - Teste de Seleção\n");

            int[] n = new int[4];
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(linha[i]);
            }

            if (n[1] > n[2] && n[3] > n[0] && (n[2] + n[3]) > (n[0] + n[1]) && n[2] > 0 && n[3] > 0 && n[0] % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}