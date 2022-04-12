using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(5, 3);
            Console.WriteLine("Posição: " + P);
        }
    }
}
