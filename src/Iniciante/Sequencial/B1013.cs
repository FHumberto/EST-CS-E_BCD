using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1013 : Problema
    {
        public static int Maior(int a, int b)
        {
            return (a + b + Math.Abs(a - b)) / 2;
        }

        public override void PMain()
        {
            Console.WriteLine("\nProblema 1013 - O Maior\n");

            int[] valor = new int[3];
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < linha.Length; i++)
            {
                valor[i] = int.Parse(linha[i]);
            }

            int maiorAb = Maior(valor[0], valor[1]);
            int maior = Maior(maiorAb, valor[2]);

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}