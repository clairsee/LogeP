using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag72PosElemento0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = new int[100], zero = new int[100];
            Random r = new Random();
            int zeros = 0, pos = 0, j = 0;

            for (int i = 0; i<100; i++)
            {
                matriz[i] = r.Next(0, 100);
            }

            foreach(int c in matriz)
            {
                pos++;
                if (c == 0)
                {
                    zeros++;
                    zero[j] = pos;
                    j++;
                }
            }

            Console.Write("A posição dos Zeros na Matriz: ");
            for (int i = 0; i < zeros; i++)
            {
                Console.Write(zero[i]);
                if (i < zeros - 1)
                {
                    Console.Write(" - ");
                }
            }
            Console.ReadKey();
        }
    }
}
