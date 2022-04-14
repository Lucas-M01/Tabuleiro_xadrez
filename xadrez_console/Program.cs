using System;
using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    
                    Console.WriteLine();
                    Console.Write("Origem : ");
                    Posicao origem = Tela.lerposicaoXadrez().toPosicao();

                    bool[,] possicoesPociveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, possicoesPociveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerposicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
