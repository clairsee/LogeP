using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag72VetorMaiorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = new int[50];
            Random r = new Random();
            int maxValue = int.MinValue;

            for (int i = 0; i<50; i++)
            {
                matriz[i] = r.Next(100);
            }

            foreach (int c in matriz)
            {
                if (c > maxValue)
                {
                    maxValue = c;
                }
            }

            Console.Write($"Na Matriz de 50 elementos, o maior valor foi: {maxValue}");
            Console.ReadKey();
        }
    }
}
