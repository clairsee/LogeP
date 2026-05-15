using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual tamanho de sequência deseja: ");
            int quant = int.Parse(Console.ReadLine());
            Console.Clear();
            int[] seq = SeqFib(quant);
            for (int i = 0; i < quant; i++)
            {
                Console.Write(seq[i] + " ");
            }
            Console.ReadKey();
        }

        static int[] SeqFib(int quant)
        {
            int[] seq = new int[quant];
            if (quant > 0) { seq[0] = 1; };
            if (quant > 1) { seq[1] = 1; };
            for (int i = 2; i < quant; i++)
            {
                seq[i] = seq[i - 2] + seq[i-1];
            }
            return seq;
        }
    }
}
