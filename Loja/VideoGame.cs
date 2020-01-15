using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class VideoGame : Produto
    {
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public string Marca { get ; set ; }
        public string Modelo { get ; set; }
        public bool IsUsado { get ; set; }

        public void calculaImposto()
        {
            if (IsUsado == true)
            {
                double imposto = Preco * 0.25;
                Console.WriteLine(Nome + " tem um imposto de " + imposto + " reais sob seu preço.");
            }
            else
            {
                double imposto = Preco * 0.45;
                Console.WriteLine(Nome + " tem um imposto de " + imposto + " reais sob seu preço.");
            }
        }


    }








}
