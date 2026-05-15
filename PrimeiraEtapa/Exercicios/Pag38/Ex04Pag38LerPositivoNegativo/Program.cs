using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag38LerPositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, result;
            Console.Write("Digite um Número (Positivo ou Negativo): ");
            num = double.Parse(Console.ReadLine());

            Console.Clear();

            if (num >= 0)
            {
                result = Math.Sqrt(num);
                Console.Write($"Como o número era maior ou igual a 0, tiramos a raiz dele\nResultado: {result}");
            } 
            else 
            {
                result = Math.Pow(num, 2);
                Console.Write($"Como o número era menor a 0, elevamos ao quadrado\nResultado: {result}");
            }
            Console.ReadKey();
        }
    }
}
