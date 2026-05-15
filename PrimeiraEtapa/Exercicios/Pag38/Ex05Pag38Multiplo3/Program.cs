using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag38Multiplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada;

            Console.Write("Escreva um número para saber se é múltiplo de 3: ");
            entrada = int.Parse(Console.ReadLine());

            if (entrada % 3 == 0)
            {
                Console.Write($"O Número {entrada} é múltiplo de 3");
            }
            
            else
            {
                Console.Write($"O Número {entrada} não é múltiplo de 3");
            }
            
            Console.ReadKey();
        }
    }
}
