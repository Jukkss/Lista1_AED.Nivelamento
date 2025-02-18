/* Lista1_AED - Questão6 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarLivro("Livro1", "Autor1", "Editora1");
            biblioteca.AdicionarLivro("Livro2", "Autor2", "Editora2");
            biblioteca.AdicionarLivro("Livro3", "Autor3", "Editora3");
            biblioteca.AdicionarLivro("Livro4", "Autor4", "Editora4");

            string tituloBusca = "Livro2";
            Livro livroEncontrado = biblioteca.BuscarLivroPorTitulo(tituloBusca);
            if (livroEncontrado != null)
            {
                Console.WriteLine($"Livro encontrado: \nTítulo: {livroEncontrado.Titulo}\nAutores: {livroEncontrado.Autores}\nEditora: {livroEncontrado.Editora}\n");
            }
            else
            {
                Console.WriteLine($"Erro: O livro com o título '{tituloBusca}' não foi encontrado.\n");
            }
            Console.WriteLine("Lista de todos os livros na biblioteca:");
            Console.WriteLine(biblioteca.ListarLivros());
            Console.WriteLine($"\nNúmero de livros na biblioteca: {biblioteca.NumLivros}");
        }
    }
}
