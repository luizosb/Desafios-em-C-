using System;

namespace VerificaTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada;
            Triangulo objeto;
            objeto = new Triangulo();
            Console.WriteLine("Este programa verefica se 3 valores informados formam um triângulo.");
            Console.WriteLine("Digite o valor do lado A: ");
            entrada = Console.ReadLine();
            objeto.ladoA = Convert.ToInt32(entrada);
            Console.WriteLine("Digite o valor do lado B: ");
            entrada = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(entrada);
            Console.WriteLine("Digite o valor do lado C: ");
            entrada = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(entrada);
            objeto.verificaTriangulo();
            Console.ReadKey();

        }
    }
}
