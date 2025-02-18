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
            biblioteca.AdicionarLivro("Cem Anos de Solidão", "Gabriel García Márquez", "Editora XYZ");
            biblioteca.AdicionarLivro("Dom Casmurro", "Machado de Assis", "Editora ABC");
            biblioteca.AdicionarLivro("1984", "George Orwell", "Editora 123");
            biblioteca.AdicionarLivro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Editora 456");

            string tituloBusca = "1984";
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
