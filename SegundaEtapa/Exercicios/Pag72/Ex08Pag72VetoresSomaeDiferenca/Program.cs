using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08Pag72VetoresSomaeDiferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz1 = new int[50], matriz2 = new int[50], matrizSoma = new int[50], matrizDif = new int[50];
            Random r = new Random();

            for (int i = 0; i < matriz1.Length; i++)
            {
                matriz1[i] = r.Next(0, 100);
                matriz2[i] = r.Next(0, 100);
                matrizSoma[i] = matriz1[i] + matriz2[i];
                matrizDif[i] = matriz1[i] - matriz2[i];
            }

            Console.Write("Valores da Primeira Matriz: ");
            for (int i = 0; i < matriz1.Length; i++)
            {
                Console.Write(matriz1[i]);
                if (i < matriz1.Length-1)
                {
                    Console.Write(" - ");
                }
                else
                {
                    Console.Write("\n\n");
                }
            }
            Console.Write("Valores da Segunda Matriz: ");
            for (int i = 0; i < matriz2.Length; i++)
            {
                Console.Write(matriz2[i]);
                if (i < matriz2.Length - 1)
                {
                    Console.Write(" - ");
                }
                else
                {
                    Console.Write("\n\n");
                }
            }
            Console.Write("Valores da Soma das Matrizez: ");
            for (int i = 0; i < matrizSoma.Length; i++)
            {
                Console.Write(matrizSoma[i]);
                if (i < matrizSoma.Length - 1)
                {
                    Console.Write(" - ");
                }
                else
                {
                    Console.Write("\n\n");
                }
            }
            Console.Write("Valores da Diferença das Matrizes: ");
            for (int i = 0; i < matrizDif.Length; i++)
            {
                Console.Write(matrizDif[i]);
                if (i < matrizDif.Length - 1)
                {
                    Console.Write(" - ");
                }
                else
                {
                    Console.Write("\n\n");
                }
            }
            Console.ReadKey();
        }
    }
}
