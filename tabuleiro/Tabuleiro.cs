namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;    
            pecas = new Peca[Linha, Coluna];
        }
    }
}
