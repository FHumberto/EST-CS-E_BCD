using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

using E_BCD.src.Template;

namespace E_BCD.src.Iniciante.Sequencial
{
    internal class B1042 : Problema
    {
        public override void PMain()
        {
            Console.WriteLine("\nProblema 1042 - Sort Simples\n");

            int[] valores = new int[3];
            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < linha.Length; i++)
            {
                valores[i] = int.Parse(linha[i]);
            }

            int[] ordenado = valores.OrderBy(x => x).ToArray();

            foreach (int i in ordenado)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in valores)
            {
                Console.WriteLine(i);
            }
        }
    }
}