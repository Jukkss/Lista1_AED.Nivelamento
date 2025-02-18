/* Lista1_AED - Questão5 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    internal class Time
    {
        private string nome;
        private Jogador[] titulares;
        private int quantTitulares;
        private Jogador[] reservas;
        private int quantReservas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Jogador[] Titulares
        {
            get { return titulares; }
        }
        public int QuantTitulares
        {
            get { return quantTitulares; }
        }
        public Jogador[] Reservas
        {
            get { return reservas; }
        }
        public int QuantReservas
        {
            get { return quantReservas; }
        }

        public Time(string nome)
        {
            this.nome = nome;
            this.titulares = new Jogador[11];
            this.reservas = new Jogador[12];
            this.quantTitulares = 0;
            this.quantReservas = 0;
        }
        public bool AdicionarTitular(Jogador jogador)
        {
            if (quantTitulares < 11)
            {
                titulares[quantTitulares++] = jogador;
                return true;
            }
            return false;
        }
        public bool AdicionarReserva(Jogador jogador)
        {
            if (quantReservas < 12)
            {
                reservas[quantReservas++] = jogador;
                return true;
            }
            return false;
        }
        public bool SubstituirTitular(string nomeTitular, Jogador novoJogador)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == nomeTitular)
                {
                    titulares[i] = novoJogador;
                    return true;
                }
            }
            return false;
        }
        public bool SubstituirReserva(string nomeReserva, Jogador novoJogador)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == nomeReserva)
                {
                    reservas[i] = novoJogador;
                    return true;
                }
            }
            return false;
        }
        public bool ConsultarTitular(string nomeTitular)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == nomeTitular)
                    return true;
            }
            return false;
        }
        public bool ConsultarReserva(string nomeReserva)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == nomeReserva)
                    return true;
            }
            return false;
        }
        public bool ExcluirTitular(string nomeTitular)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == nomeTitular)
                {
                    for (int j = i; j < quantTitulares - 1; j++)
                    {
                        titulares[j] = titulares[j + 1];
                    }
                    titulares[quantTitulares - 1] = null;
                    quantTitulares--;
                    return true;
                }
            }
            return false;
        }
        public bool ExcluirReserva(string nomeReserva)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == nomeReserva)
                {
                    for (int j = i; j < quantReservas - 1; j++)
                    {
                        reservas[j] = reservas[j + 1];
                    }
                    reservas[quantReservas - 1] = null;
                    quantReservas--;
                    return true;
                }
            }
            return false;
        }
        public void GerarArqTime(string nomeArquivo)
        {
            using (StreamWriter arql = new StreamWriter("Time.txt", false, Encoding.UTF8))
            {
                arql.WriteLine($"Time: {nome}\nTitulares:");
                foreach (var jogador in titulares)
                {
                    if (jogador != null)
                        arql.WriteLine($"Nome: {jogador.Nome}, Número: {jogador.Numero}, Posição: {jogador.Posicao}");
                }

                arql.WriteLine("\nReservas:");
                foreach (var jogador in reservas)
                {
                    if (jogador != null)
                        arql.WriteLine($"Nome: {jogador.Nome}, Número: {jogador.Numero}, Posição: {jogador.Posicao}");
                }
            }
        }
    }
}
