using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Pag72ValoresProcedurais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = new int[30];
            int num = 1;

            Console.Write("Matriz: ");
            for (int i = 0; i<matriz.Length; i++)
            {
                matriz[i] = num;
                num++;
                Console.Write(matriz[i]);
                if (i < matriz.Length-1)
                {
                    Console.Write(" - ");
                }
            }
            Console.ReadKey();
        }
    }
}
