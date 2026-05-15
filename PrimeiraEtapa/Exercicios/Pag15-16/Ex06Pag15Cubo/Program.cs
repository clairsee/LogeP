using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Pag15Cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladocubo;
            double cubo;
            Console.Write("Qual o valor do lado do Cubo: ");
            ladocubo = double.Parse(Console.ReadLine());
            Console.Clear();
            cubo = ladocubo*ladocubo*ladocubo;
            Console.Write($"O valor do Volume do cubo será igual a: {cubo}");
            Console.ReadKey();
        }
    }
}
