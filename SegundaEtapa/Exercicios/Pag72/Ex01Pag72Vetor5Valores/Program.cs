using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag72Vetor5Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int[] matriz = new int[5];

            for (int i = 0; i<5; i++)
            {
                Console.Write("Escreva um valor inteiro: ");
                matriz[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.Write("A Matriz montada: \nMatriz: ");
            for (int i = 0; i < 5; i++)
            {

                Console.Write(matriz[i]);
                if (i < 4) { Console.Write(" - "); }
            }
            Console.ReadKey();
        }
    }
}
