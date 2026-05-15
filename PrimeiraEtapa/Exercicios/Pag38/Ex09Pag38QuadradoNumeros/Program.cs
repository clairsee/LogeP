using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09Pag38QuadradoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, maiorQuad, menorQuad;

            Console.Write("Escreva o primeiro valor: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o segundo valor: ");
            num2 = double.Parse(Console.ReadLine());

            maiorQuad = Math.Sqrt(Math.Max(num1,num2));
            menorQuad = Math.Pow(Math.Min(num1, num2), 2);

            Console.Write($"O maior número ao quadrado será {maiorQuad}\nO menor número ao quadrado será {menorQuad}");
            Console.ReadKey();
        }
    }
}
