using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag38PermutarVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA, numB;

            Console.Write("Escreva o valor para a variável A: ");
            numA = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor para a variável B: ");
            numB = int.Parse(Console.ReadLine());

            numB = numA + numB;
            numA = numB - numA;
            numB = numB - numA;


            Console.Write($"Os valores das variáveis foram trocados. A = B e B = A.\nA = {numA}\nB = {numB}");
            Console.ReadKey();
        }
    }
}
