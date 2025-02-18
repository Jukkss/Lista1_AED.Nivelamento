/* Lista1_AED - Questão5 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    internal class Jogador
    {
        private int numero;
        private string nome;
        private string posicao;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        public Jogador(int numero, string nome, string posicao)
        {
            this.numero = numero;
            this.nome = nome;
            this.posicao = posicao;
        }
    }
}
