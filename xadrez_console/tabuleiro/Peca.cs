namespace xadrez_console.tabuleiro
{
     class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public Tabuleiro tab { get; set; }
        public int qte_movimentos { get; set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qte_movimentos = 0;
        }
    }
}
