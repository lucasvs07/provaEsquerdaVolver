using System;

namespace provaEsquerdaVolver.ConaoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentido = "N";

            Console.WriteLine("Quantas ordens o soldado deve executar?");
            string strQuantidadeDeOrdens = Console.ReadLine();
            int quantidadeDeOrdens = Convert.ToInt32(strQuantidadeDeOrdens);

            Console.Write("Quais as ordens que devem ser executadas?\n" +
                "Considere D para direita e E para esquerda.");
            string strOrdens = Console.ReadLine();
            char[] ordens = strOrdens.ToCharArray();

            for (int i = 0; i < quantidadeDeOrdens; i++)
            {
                if (ordens [i] == 'D' && sentido == "N")
                {
                    sentido = "L";
                }
                else if (ordens[i] == 'E' && sentido == "N")
                {
                    sentido = "O";
                }
                else if (ordens[i] == 'D' && sentido == "L")
                {
                    sentido = "N";
                }
                else if (ordens[i] == 'E' && sentido == "L")
                {
                    sentido = "S";
                }
                else if (ordens[i] == 'D' && sentido == "S")
                {
                    sentido = "O";
                }
                else if (ordens[i] == 'E' && sentido == "S")
                {
                    sentido = "L";
                }
                else if (ordens[i] == 'D' && sentido == "O")
                {
                    sentido = "N";
                }
                else if (ordens[i] == 'E' && sentido == "O")
                {
                    sentido = "S";
                }

            }

            Console.WriteLine(sentido);
        }
    }
}
