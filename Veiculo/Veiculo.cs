using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    class Veiculo
    {
        private string modelo;
        private string marca;
        private string placa;
        private string cor;
        private int passageiros;
        private int km;
        private bool isLigado;
        private double litrosCombustivel;
        private double velocidade;
        private double preco;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Passageiros { get => passageiros; set => passageiros = value; }
        public int Km { get => km; set => km = value; }
        public bool IsLigado { get => isLigado; set => isLigado = value; }
        public double LitrosCombustivel { get => litrosCombustivel; set => litrosCombustivel = value; }
        public double Velocidade { get => velocidade; set => velocidade = value; }
        public double Preco { get => preco; set => preco = value; }

        public void Dados()
        {
            Console.WriteLine("A marca do carro é " + this.Marca + " do modelo " + this.Modelo + ", número da placa: " + this.Placa + ". Com a cor : " + this.Cor);
        }

        public void Pintar()
        {
            String entrada = ""; 
            Console.WriteLine("Para qual cor gostaria de mudar ? ");
            entrada = Console.ReadLine();
            Cor = entrada;
            Console.WriteLine("Agora a cor é " + this.Cor);
        }
       
        public void Acelerar()
        {
            if (this.IsLigado == true && this.LitrosCombustivel > 0)
            {
                this.Velocidade = this.Velocidade + 20;
                Console.WriteLine("Agora a velocidade é de " + this.Velocidade + " km/H.");
            }
            else if (this.IsLigado == false && this.LitrosCombustivel > 0)
            {
                Console.WriteLine("Ligue o carro para acelerar.");
            } 
            else
            {
                Console.WriteLine("Abasteça o carro para acelerar.");
            }

        }

        public void Frear()
        {
            if (this.IsLigado == true && this.Velocidade > 0)
            {
                if (this.Velocidade < 50) 
                {
                    this.Velocidade = 0;
                }
                else 
                {
                    Velocidade = Velocidade - 50;
                }
                Console.WriteLine("A velocidade do carro foi para " + this.Velocidade + " km/H.");
            }
            else if (this.IsLigado == false)
            {
                Console.WriteLine("O carro está desligado, não é possivel freiar.");
            }
            else
            {
                Console.WriteLine("A velocidade ja esta em 0.");
            }


        }

        public void Abastecer(int gasosa)
        {
            if ((this.LitrosCombustivel + gasosa) > 100)
            {
                Console.WriteLine("Não é possivel abastecer essa quantidade, apenas é possível abastecer " + (100 - this.LitrosCombustivel) + " de combustível.");
                this.LitrosCombustivel = 100;
            }
            else
            {
                LitrosCombustivel = this.LitrosCombustivel + gasosa;
                Console.WriteLine("Veículo abastecido com sucesso.");
            }
            Console.WriteLine("O veículo possui agora " + this.LitrosCombustivel + " litros no tanque.");
        }

        public void Ligar()
        {
            if (this.IsLigado == false && this.LitrosCombustivel > 0)
            {
                this.IsLigado = true;
                Console.WriteLine("Agora o carro está ligado.");
            }
            else if(this.LitrosCombustivel == 0 && this.IsLigado == false && this.Velocidade == 0)
            {
                Console.WriteLine("Para ligar o veículo, necessita abastece-lo primeiro.");
            } else
            {
                Console.WriteLine("O veículo já esta ligado.");
            }
        }

        public void Desligar()
        {
            if (this.IsLigado == true && this.Velocidade == 0)
            {
                this.IsLigado =false;
                Console.WriteLine("O veículo foi desligado.");
            }
            else if (this.IsLigado == false)
            {
                Console.WriteLine("O veículo já está desligado.");
            }
            else
            {
                Console.WriteLine("Para desligar, pare o veículo primeiro.");
            }
        }

    }
}
