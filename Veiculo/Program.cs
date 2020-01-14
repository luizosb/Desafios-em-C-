using System;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            Veiculo carro;
            carro = new Veiculo();
            /*Console.WriteLine("Este programa recebe informações de um carro.");
            Console.WriteLine("Digite o marca do carro: ");
            entrada = Console.ReadLine();
            carro.Marca = entrada;
            Console.WriteLine("Digite o modelo do carro: ");
            entrada = Console.ReadLine();
            carro.Modelo = entrada;
            Console.WriteLine("Digite a placa do carro: ");
            entrada = Console.ReadLine();
            carro.Placa = entrada;
            Console.WriteLine("Digite qual a cor do carro que gostaria: ");
            entrada = Console.ReadLine();
            carro.Cor = entrada;
            Console.WriteLine("Digite a quantidade passageiros que tem no carro: ");
            entrada = Console.ReadLine();
            carro.Passageiros = Convert.ToInt32(entrada);
            Console.WriteLine("Digite a quilometragem do carro: ");
            entrada = Console.ReadLine();
            carro.Km = Convert.ToInt32(entrada);
            Console.WriteLine("Qual foi o preço deste carro? ");
            entrada = Console.ReadLine();
            carro.Preco = Convert.ToDouble(entrada);
            */

            carro.Abastecer(100);
            carro.Ligar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Pintar();
            carro.Frear();
            carro.Desligar();
            carro.Frear();
            carro.Frear();
            carro.Desligar();


        }
    }
}
