using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos{ get; set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tab;
            QtdMovimentos = 0;
        }

        
    }
}
