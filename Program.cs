using E_BCD.Iniciante.Inicio;
using E_BCD.Iniciante.Sequencial;

namespace E_BCD
{
    internal static class Program
    {
        public static void Main()
        {
            string? comando;
            do
            {
                Console.WriteLine("Informe o número do problema: [1000, 1001, ...]");
                int problema = Convert.ToInt32(Console.ReadLine());

                switch (problema)
                {
                    case 1000:
                        do
                        {
                            B1000.PMain();
                            Mensagem(0, problema);
                            comando = Console.ReadLine();
                        } while (comando == "S" || comando == "s");
                        break;

                    case 1001:
                        do
                        {
                            B1001.PMain();
                            Mensagem(0, problema);
                            comando = Console.ReadLine();
                        } while (comando == "S" || comando == "s");
                        break;

                    case 1002:
                        do
                        {
                            B1002.PMain();
                            Mensagem(0, problema);
                            comando = Console.ReadLine();
                        } while (comando == "S" || comando == "s");
                        break;

                    case 1003:
                        do
                        {
                            B1003.PMain();
                            Mensagem(0, problema);
                            comando = Console.ReadLine();
                        } while (comando == "S" || comando == "s");
                        break;

                    case 1004:
                        do
                        {
                            B1004.PMain();
                            Mensagem(0, problema);
                            comando = Console.ReadLine();
                        } while (comando == "S" || comando == "s");
                        break;

                    default:
                        Console.WriteLine("O problema informado não existe.");
                        break;
                }
                Mensagem(1);
                comando = Console.ReadLine();
            } while (comando == "S" || comando == "s");
        }

        public static void Mensagem(int operacao, int problema = default)
        {
            if (operacao == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Deseja executar o problema B{problema} novamente? [S/N]");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Deseja executar o programa novamente? [S/N]");
            }
        }
    }
}