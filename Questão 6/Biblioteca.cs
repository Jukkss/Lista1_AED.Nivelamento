/* Lista1_AED - Questão6 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    internal class Biblioteca
    {
        private const int MAXLIV = 50;
        private Livro[] acervo;
        private int numLivros;

        public int NumLivros
        {
            get { return numLivros; }
        }
        public Biblioteca()
        {
            acervo = new Livro[MAXLIV];
            numLivros = 0;
        }
        public bool AdicionarLivro(string titulo, string autores, string editora)
        {
            if (numLivros < MAXLIV)
            {
                acervo[numLivros++] = new Livro(titulo, autores, editora);
                return true;
            }
            return false;
        }
        public bool AdicionarLivro(Livro livro)
        {
            if (numLivros < MAXLIV)
            {
                acervo[numLivros++] = livro;
                return true;
            }
            return false;
        }
        public Livro BuscarLivroPorTitulo(string titulo)
        {
            foreach (var livro in acervo)
            {
                if (livro != null && livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return livro;
                }
            }
            return null;
        }
        public string ListarLivros()
        {
            string listaLivros = "";
            foreach (var livro in acervo)
            {
                if (livro != null)
                {
                    listaLivros += livro.Titulo + "\n";
                }
            }
            return listaLivros;
        }
    }
}
