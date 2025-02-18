/* Lista1_AED - Questão3 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class Q3
    {
        static void PreencherVets(int[] x, int[] y, int n)
        {
            Console.WriteLine("\tVetor X");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Posição:{i}");
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\tVetor Y");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Posição:{i}");
                y[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            int[] x, y;
            Console.WriteLine("Informe o número de elementos dos vetores");
            int n = int.Parse(Console.ReadLine());
            y = new int[n]; x = new int[n];

            Console.WriteLine("\n\tPREENCHER");
            PreencherVets(x, y, n);

            Console.WriteLine("\n\tSOMA");
            double soma;
            for (int i = 0; i < n; i++)
            {
                soma = 0;
                soma = x[i] + y[i];
                Console.WriteLine($"Posição {i} = {soma}");
            }

            Console.WriteLine("\n\tPRODUTO");
            int prod;
            for (int i = 0; i < n; i++)
            {
                prod = 0;
                prod = x[i] * y[i];
                Console.WriteLine($"Posição {i} = {prod}");
            }

            Console.WriteLine("\n\tDIFERENÇA");
            int dif;
            for (int i = 0; i < n; i++)
            {
                dif = 0;
                dif = x[i] - y[i];
                Console.WriteLine($"Posição {i} = {dif}");
            }

            Console.WriteLine("\n\tINTERSEÇÃO");
            int inter = 0;
            foreach (int i in x)
            {
                foreach (int j in y)
                {
                    if (i == j)
                    {
                        Console.WriteLine(i);
                        inter++;
                    }
                }
            }
            if (inter == 0)
            {
                Console.WriteLine("Sem elementos iguais");
            }

            Console.WriteLine("\n\tUNIÃO");
            int verf = 0, verf2 = 0;
            foreach (int i in x)
            {
                foreach (int j in y)
                {
                    if (i == j)
                    {
                        verf++;
                    }
                }
                if (verf == 0)
                {
                    Console.WriteLine($"{i} exclusivo de X");
                    verf2++;
                }
                verf = 0;
            }
            if (verf2 == 0)
            {
                Console.WriteLine("Sem elmentos exclusivos");
            }
        }
    }
}
