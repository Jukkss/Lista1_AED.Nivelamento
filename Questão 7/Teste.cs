/* Lista1_AED - Questão7 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Questão_7
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento("Estacionamento Central", 30);

            estacionamento.Estacionar("CCCCCCC");
            estacionamento.Estacionar("DDDDDDD");
            estacionamento.Estacionar("EEEEEEE");
            estacionamento.Estacionar("FFFFFFF");
            estacionamento.Estacionar("GGGGGGG");

            Console.WriteLine("Ocupação inicial do estacionamento:");
            estacionamento.ExibirOcupacao();
            string placaBusca = "DDDDDDD";
            int vaga = estacionamento.BuscarNumVaga(placaBusca);
            Console.WriteLine($"\nPlaca {placaBusca} está na vaga: {vaga}\n");
            estacionamento.Retirar("CCCCCCC");
            Console.WriteLine("Após retirar o veículo com a placa CCCCCCC:");
            estacionamento.ExibirOcupacao();

            estacionamento.Estacionar("AAAAAAA");
            estacionamento.Estacionar("BBBBBBB");
            estacionamento.Estacionar("HHHHHHH");

            Console.WriteLine("Após estacionar mais 3 carros:");
            estacionamento.ExibirOcupacao();
            Console.WriteLine($"\nQuantidade de vagas livres: {estacionamento.NumVagasLivres}");
        }
    }
}
