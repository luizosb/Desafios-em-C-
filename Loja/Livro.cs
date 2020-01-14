using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class Livro : Produto
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }


        public string Autor { get => autor; set => autor = value; }
        public string Tema { get => tema; set => tema = value; }
        public int QtdPag { get => qtdPag; set => qtdPag = value; }
    
        public void calculaImposto()
        {
            if (tema == "educativo")
            {
                double imposto = Preco * 0;
                Console.WriteLine("O imposto sobre o livro " + Nome + " é de " + imposto + " reais.");
            }
            else
            {
                double imposto = Preco * 0.1;
                Console.WriteLine("O imposto sobre o livro " + Nome + " é de " + imposto + " reais.");
            }
        }
    }

}
