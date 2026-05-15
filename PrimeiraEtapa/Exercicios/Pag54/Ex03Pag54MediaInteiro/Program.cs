using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag54MediaInteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, quant = 0, media = 0, arit = 0;
            while (true)
            {
                do {
                    Console.Write("Digite 0 para sair do programa\nEscreva um valor inteiro positivo para fazer um cálculo aritmético: ");
                    num = int.Parse(Console.ReadLine());
                    if (num < 0) { Console.Clear(); Console.Write("Escreva um valor inteiro e positivo\n"); } else { quant += 1; }
                } while (num < 0);

                Console.Clear();
                if (num == 0) { Console.Write("Obrigado por usar o programa\n"); break; };

                media += num;
                arit = media / quant;
            }

            Console.Write($"A média de todos os números será: {arit}");
            Console.ReadKey();
        }
    }
}
