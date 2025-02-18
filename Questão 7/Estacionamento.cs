/* Lista1_AED - Questão7 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Questão_7
{
    internal class Estacionamento
    {
        private string nome;
        private int numVagasLivres;
        private string[] vagas;

        public Estacionamento(string nome, int numTotalVagas)
        {
            this.nome = nome;
            this.numVagasLivres = numTotalVagas;
            this.vagas = new string[numTotalVagas];
        }
        public int Estacionar(string placa)
        {
            if (numVagasLivres > 0)
            {
                for (int i = 0; i < vagas.Length; i++)
                {
                    if (vagas[i] == null)
                    {
                        vagas[i] = placa;
                        numVagasLivres--; 
                        return i;
                    }
                }
            }
            return -1; 
        }
        public int BuscarNumVaga(string placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    return i; 
                }
            }
            return -1; 
        }
        public void Retirar(string placa)
        {
            int vaga = BuscarNumVaga(placa);
            if (vaga != -1)
            {
                vagas[vaga] = null; 
                numVagasLivres++; 
            }
        }
        public int NumVagasLivres
        {
            get { return numVagasLivres; }
        }
        public void ExibirOcupacao()
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == null)
                {
                    Console.WriteLine($"Vaga {i}: Vazia");
                }
                else
                {
                    Console.WriteLine($"Vaga {i}: Ocupada por {vagas[i]}");
                }
            }
        }
    }
}
