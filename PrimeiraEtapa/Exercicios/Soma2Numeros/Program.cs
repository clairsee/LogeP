using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma2Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            decimal total, media;

            Console.Write("Digite o primeiro número inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Digite o segundo número inteiro: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Digite o terceiro número inteiro: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            total = num1 + num2 + num3;
            media = total / 3;

            Console.Write($"O resultado dessa soma será: {num1} + {num2} + {num3} = {total}\nE a média dos três é: {media}");
            Console.ReadKey();
        }
    }
}
