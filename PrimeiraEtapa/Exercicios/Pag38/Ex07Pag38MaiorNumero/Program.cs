using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07Pag38MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, maior;

            Console.Write("Escreva o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Escreva o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            maior = Math.Max(num1, num2);

            Console.Write($"O maior valor entre os dois é {maior}");
            Console.ReadKey();
        }
    }
}
