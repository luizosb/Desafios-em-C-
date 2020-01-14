using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    class VideoGame : Produto
    {
        private string marca;
        private string modelo;
        private bool isUsado;

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public bool IsUsado { get => isUsado; set => isUsado = value; }

        public void calculaImposto()
        {
            if (isUsado == true)
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
