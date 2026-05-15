using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag72VetorValorMaior50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Matriz = new int[20];
            int j = 0;
            Random r = new Random();

            for (int i = 0; i<20; i++)
            {
                Matriz[i] = r.Next(100);
            }

            Console.Write("Apenas valores acima de 50 postos na Matriz: \nValores: ");
            foreach (int c in Matriz)
            {
                j++;
                if (c > 50)
                {
                    Console.Write(c);
                    if (j < 20) { Console.Write(" - "); }
                }
            }

            Console.ReadKey();
        }
    }
}
