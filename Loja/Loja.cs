using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class Loja
    {
        private string nome;
        private string cnpj;
        private List<Livro> livros;
        private List<VideoGame> videoGame;

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGame)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Livros = livros;
            this.VideoGame = videoGame;
        }


        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        internal List<Livro> Livros { get => livros; set => livros = value; }
        internal List<VideoGame> VideoGame { get => videoGame; set => videoGame = value; }

        public void listaLivros()
        {
            for ( int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine("O livro é " + livros.Count(i);
            }
        }





    }
}
