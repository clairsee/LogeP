using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteioLoteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            while (true)
            {
                Console.Clear();
                Console.Write("Sorteio de Números Mega-Sena\nNúmeros: ");
                for (int i = 0; i < 6; i++)
                {
                    int n = r.Next(1, 60);
                    Console.Write(n);
                    if (i < 5)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.Write("\n\nDigite 0 para SAIR do programa: ");
                if(Console.ReadLine() == "0")
                {
                    break;
                }
            }
        }
    }
}
