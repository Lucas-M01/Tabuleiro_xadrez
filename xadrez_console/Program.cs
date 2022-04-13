using System;
using xadrez_console.tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));

                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);

                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
