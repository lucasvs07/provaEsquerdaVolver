using System;

namespace provaEsquerdaVolver.ConaoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sentido = 'N';
            
            int quantidadeDeOrdens = 1;
            string sentidoFinal = "";
            char[] ordens = { };

            while (true)
            {
                
                Console.WriteLine("Quantas ordens o soldado deve executar?");
                string strQuantidadeDeOrdens = Console.ReadLine();
                quantidadeDeOrdens = Convert.ToInt32(strQuantidadeDeOrdens);
                char[] qtdordens = new char[quantidadeDeOrdens];

                if (quantidadeDeOrdens == 0)
                    break;
                else
                {
                    for (int j = 1; j <= quantidadeDeOrdens; j++)
                    {
                        Console.Write("Quais as ordens que devem ser executadas?\n" +
                            "Considere D para direita e E para esquerda.\n");
                        string strOrdens = Console.ReadLine();
                        string strOrdensTotal = "" + strOrdens;
                        ordens = strOrdensTotal.ToCharArray();

                    }


                        for (int i = 1; i <= quantidadeDeOrdens; i++)
                        {
                            if (ordens[i] == 'D' && sentido == 'N')
                            {
                                sentido = 'L';
                            }
                            else if (ordens[i] == 'E' && sentido == 'N')
                            {
                                sentido = 'O';
                            }
                            else if (ordens[i] == 'D' && sentido == 'L')
                            {
                                sentido = 'N';
                            }
                            else if (ordens[i] == 'E' && sentido == 'L')
                            {
                                sentido = 'S';
                            }
                            else if (ordens[i] == 'D' && sentido == 'S')
                            {
                                sentido = 'O';
                            }
                            else if (ordens[i] == 'E' && sentido == 'S')
                            {
                                sentido = 'L';
                            }
                            else if (ordens[i] == 'D' && sentido == 'O')
                            {
                                sentido = 'N';
                            }
                            else if (ordens[i] == 'E' && sentido == 'O')
                            {
                                sentido = 'S';
                            }

                        }
                    
                    sentidoFinal = "\n" + sentido;
                }
            }
            Console.WriteLine(sentidoFinal);
        }
    }
}
