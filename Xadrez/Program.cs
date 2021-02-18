﻿using System;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
