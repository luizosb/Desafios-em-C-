using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class Loja
    {
       
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGame)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Livros = livros;
            this.VideoGame = videoGame;
        }


        public string Nome { get ; set; }
        public string Cnpj { get; set ; }
        internal List<Livro> Livros { get; set; }
        internal List<VideoGame> VideoGame { get ; set ; }

        public void listaLivros()
        {
            foreach ( Livro livros in Livros)
            {
                Console.WriteLine("O livro é " + livros.Nome + ", com o preço de " + livros.Preco + ", com o estoque de " + livros.Qtd + ".");
            }
        }

        public void listaVideoGames()
        {
            foreach (VideoGame videoGame in VideoGame)
            {
                Console.WriteLine("O livro é " + videoGame.Nome + ", com o preço de " + videoGame.Preco + ", com o estoque de " + videoGame.Qtd + ".");
            }
        }

        public void calculaPatrimonio()
        {
            double x = 0;
            double y = 0;
            foreach (Livro livros in Livros)
            {
                x = x + (livros.Qtd * livros.Preco);
            }
            foreach(VideoGame videoGames in VideoGame)
            {
                y = y + (videoGames.Qtd * videoGames.Preco);
            }
            Console.WriteLine("O patrimônio é de " + (x + y) + " reais.");
        }



    }
}
