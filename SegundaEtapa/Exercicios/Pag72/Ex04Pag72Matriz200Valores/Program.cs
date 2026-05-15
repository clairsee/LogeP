using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag72Matriz200Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = new int[200], entre = new int[200];
            Random r = new Random();
            int soma = 0, maxValue = int.MinValue, pos = 0, minValue = int.MaxValue, minPos = 0, zeros = 0, neg = 0, j = 0, entre100 = 0;
            float media, porcZero;

            for (int i = 0; i<200; i++)
            {
                matriz[i] = r.Next(-100, 200);
            }

            foreach (int c in matriz)
            {
                pos++;
                soma += c;

                if (c > maxValue)
                {
                    maxValue = c;
                }

                if (c < minValue)
                {
                    minValue = c;
                    minPos = pos;
                }

                if (c == 0)
                {
                    zeros++;
                }
                else if (c < 0)
                {
                    neg++;
                }
                else if (c > 100 && c < 200)
                {
                    entre100++;
                    entre[j] = pos;
                    j++;
                }
            }

            media = soma / 50;
            porcZero = (100 * zeros) / 50;

            Console.WriteLine($"A soma de todos os valores da Matriz é: {soma}");
            Console.WriteLine($"O valor do maior valor da Matriz é: {maxValue}");
            Console.WriteLine($"O valor do menor valor da Matriz é: {minValue} e sua posição foi: {minPos}");
            Console.WriteLine($"A média de todos os valores da Matriz é: {media}");
            Console.WriteLine($"Foram digitados: {zeros} na Matriz");
            Console.WriteLine($"O porcentual de Zeros na Matriz foi: {porcZero}%");
            Console.WriteLine($"O valor de números negativos digitados foi: {neg}");
            Console.WriteLine("As posições em que os valores estavam entre 100 e 200:");
            for (int i = 0; i<entre100; i++)
            {
                Console.Write(entre[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
