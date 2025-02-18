/* Lista1_AED - Questão5 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Time time = new Time("Time");
            Jogador jogador1 = new Jogador(10, "Jogador1", "Atacante");
            Jogador jogador2 = new Jogador(2, "Jogador2", "Goleiro");
            Jogador jogador3 = new Jogador(5, "Jogador3", "Zagueiro");
            time.AdicionarTitular(jogador1);
            time.AdicionarReserva(jogador2);
            time.AdicionarReserva(jogador3);

            Console.WriteLine(time.ConsultarTitular("Jogador1"));
            Console.WriteLine(time.ConsultarReserva("Jogador2")); 


            Jogador novoJogador = new Jogador(11, "Jogador11", "Meia");
            time.SubstituirTitular("Jogador1", novoJogador);
            time.ExcluirReserva("Jogador2");
            time.GerarArqTime("time.txt");
        }
    }
}
