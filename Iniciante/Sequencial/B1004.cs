using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BCD.Iniciante.Sequencial
{
    internal static class B1004
    {
        public static void PMain()
        {
            Console.WriteLine("\nProblema 1004 - Produto Simples\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int produto = a * b;

            Console.WriteLine($"PROD = {produto}");
        }
    }
}