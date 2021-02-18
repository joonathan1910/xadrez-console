using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        //public Rei(Tabuleiro tab,Cor cor):base(cor, tab)
        public Rei(Tabuleiro tab, Cor cor) : base(cor)
        {
        }

        public override string ToString()
        {
            return "R"; 
        }
    }
}
