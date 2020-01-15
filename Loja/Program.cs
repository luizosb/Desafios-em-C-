using System;
using System.Collections.Generic;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J.K.Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J.R.R.Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("PS4", 1500, 500, "Microsoft", "One", false);
            
            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> videoGames = new List<VideoGame>();
            videoGames.Add(ps4);
            videoGames.Add(ps4Usado);
            videoGames.Add(xbox);

            Loja kabum = new Loja("Kabum!", "12345678" , livros, videoGames);

            l1.calculaImposto();
            l2.calculaImposto();
            l3.calculaImposto();

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            ps4.calculaImposto();
            ps4Usado.calculaImposto();
            xbox.calculaImposto();

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            kabum.listaLivros();

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            kabum.listaVideoGames();

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            kabum.calculaPatrimonio();







        }
    }
}
