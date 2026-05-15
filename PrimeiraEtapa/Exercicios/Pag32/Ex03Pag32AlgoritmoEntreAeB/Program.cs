using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag32AlgoritmoEntreAeB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, resultadoFinal;

            Console.Write("Qual o valor de A: ");
            valorA = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual o valor de B: ");
            valorB = int.Parse(Console.ReadLine());
            Console.Clear();

            if (valorA == valorB) 
            {
                resultadoFinal = valorA + valorB;
            }
            else
            {
                resultadoFinal = valorA * valorB;
            }

            Console.Write($"O valor final será de {resultadoFinal}");
            Console.ReadKey();
        }
    }
}
