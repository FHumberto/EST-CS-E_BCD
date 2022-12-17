﻿using E_BCD.src.Iniciante.Inicio;
using E_BCD.src.Iniciante.Sequencial;
using E_BCD.src.Template;

namespace E_BCD.src
{
    internal static class Program
    {
        public static void ExecutarProblema(Dictionary<string, Problema> problemas, string problema)
        {
            string? comando;
            do
            {
                if (problemas.TryGetValue(problema, out Problema? problemaEncontrado))
                {
                    problemaEncontrado.PMain();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"O problema informado não existe.");
                }

                Mensagem(0, problema);
                comando = Console.ReadLine();
            } while (comando == "S" || comando == "s");
        }

        public static void Main()
        {
            //* Lista de problemas.
            Dictionary<string, Problema> listaProblemas = new()
            {
                { "1000", new B1000() },
                { "1001", new B1001() },
                { "1002", new B1002() },
                { "1003", new B1003() },
                { "1004", new B1004() },
                { "1005", new B1005() },
                { "1006", new B1006() },
                { "1007", new B1007() },
                { "1008", new B1008() },
                { "1009", new B1009() },
                { "1010", new B1010() },
                { "1011", new B1011() },
                { "1012", new B1012() },
                { "1013", new B1013() }
            };

            string? comando;
            do
            {
                Console.WriteLine("Informe o número do problema: [1000, 1001, ...]");
                string? problema = Console.ReadLine();

                //* Encontra e executa o problema informado.
                ExecutarProblema(listaProblemas, problema);

                Mensagem(1);
                comando = Console.ReadLine();
            } while (comando == "S" || comando == "s");
        }

        public static void Mensagem(int operacao, string? problema = null)
        {
            if (operacao == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Deseja executar o problema B{problema} novamente? [S/N]");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Deseja executar o todo o programa novamente? [S/N]");
            }
        }
    }
}