using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BCD.Iniciante.Sequencial
{
    internal static class B1003
    {
        public static void PMain()
        {
            Console.WriteLine("\nProblema 1003 - Soma Simples\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}