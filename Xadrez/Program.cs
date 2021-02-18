using System;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('A',1);
            Console.WriteLine( pos );

            Console.WriteLine(pos.ToPosicao());
            /*
            try { 
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 8));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 3));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
            }
            catch(TabuleiroException e ){
                Console.WriteLine(e.Message);
            }*/
        }
    }
}
