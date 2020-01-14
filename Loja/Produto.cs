using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class Produto
    {
        private string nome;
        private double preco;
        private int qtd;

        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Qtd { get => qtd; set => qtd = value; }
    }
}
