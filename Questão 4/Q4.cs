/* Lista1_AED - Questão4 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4
{
    internal class Q4
    {
        static void PreencherCandidatos(int[] candidatos, string[] nomes)
        {
            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.WriteLine($"Informe o nome do candidato {i}:");
                nomes[i] = Console.ReadLine(); 

                Console.WriteLine($"Informe o número do candidato {nomes[i]}:");
                candidatos[i] = int.Parse(Console.ReadLine()); 
            }
        }
        static void votação(int[] candidatos, string[] nomes, int[] votos, ref int nulos)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o número do voto {i+1}");
                int voto = int.Parse(Console.ReadLine());
                bool validade = false;
                for (int j = 0; j < votos.Length; j++)
                {
                    if (candidatos[j] == voto)
                    {
                        votos[j]++;
                        validade = true;
                    }
                }
                if (!validade)
                {
                    nulos++;
                }
            }
        }
        static void verificação(string[] nomes, int[] votos, ref int nulos)
        {
            int menorvotado = int.MaxValue; int maiorvotado = int.MinValue;
            string MirVtd = "", MnrVtd = "";

            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] < menorvotado)
                {
                    menorvotado = votos[i];
                    MnrVtd = nomes[i];
                }
                if (votos[i] > maiorvotado)
                {
                    maiorvotado = votos[i];
                    MirVtd = nomes[i];
                    
                }
            }
            Console.WriteLine($"Candidato com mais votos foi {MirVtd} com {maiorvotado} votos");
            Console.WriteLine($"Candidato com menos votos foi {MnrVtd} com {menorvotado} votos");
            Console.WriteLine($"Houve {nulos} votos nulos");
        }
        static void Main(string[] args)
        {
            int[] candidatos; int[] votos; string[] nomes;
            Console.WriteLine("Informe o número de candidatos:");
            int numcadt = int.Parse(Console.ReadLine());
            candidatos = new int[numcadt];
            nomes = new string[numcadt];
            votos = new int[numcadt];
            int nulos = 0;

            PreencherCandidatos(candidatos, nomes);
            votação(candidatos, nomes, votos, ref nulos);
            verificação(nomes, votos, ref nulos);
        }
    }
}
