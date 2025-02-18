/* Lista1_AED - Questão1 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_AED
{
    internal class Questão1
    {
        static void Main(string[] args)
        {
            int seqc = 0, num1, num2, mseqc = 0;

            Console.WriteLine("Informe o primeiro número da sequencia");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número da sequencia");
            num2 = int.Parse(Console.ReadLine());

            while (num2 != -1)
            {
                if (num2 > num1)
                {
                    seqc++;
                }
                else
                {
                    if (seqc > mseqc)
                    {
                        mseqc = seqc;
                        seqc = 0;
                    }
                }
                num1 = num2;
                Console.WriteLine("Informe o próximo número da sequencia");
                num2 = int.Parse(Console.ReadLine());
            }
            if (seqc > mseqc)
            {
                Console.WriteLine($"A maior sequencia foi:{seqc+1}");
            }
            else
            {
                Console.WriteLine($"A maior sequencia foi:{mseqc+1}");
            }
            
        }
    }
}
