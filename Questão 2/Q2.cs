/* Lista1_AED - Questão2 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_AED
{
    internal class Questão2
    {
        static void Main(string[] args)
        {
            int n, num = 1;

            Console.WriteLine("Informe o número (n) de linhas da pirâmida de Floyd");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }
        }

    }
}
