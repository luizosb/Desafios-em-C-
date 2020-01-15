using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class Livro : Produto
    {
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag):base(nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }

        public string Autor { get ; set ; }
        public string Tema { get ; set; }
        public int QtdPag { get ; set; }
    
        public void calculaImposto()
        {
            if (Tema == "educativo")
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
