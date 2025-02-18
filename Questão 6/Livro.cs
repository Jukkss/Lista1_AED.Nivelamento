/* Lista1_AED - Questão6 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    internal class Livro
    {
        private string titulo;
        private string autores;
        private string editora;


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        public Livro(string titulo, string autores, string editora)
        {
            this.titulo = titulo;
            this.autores = autores;
            this.editora = editora;
        }
    }
}
